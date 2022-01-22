using Xunit;
using OkOk;
using Microsoft.EntityFrameworkCore;
using OkOk.Models;
using OkOk.Controllers;
using System.Collections.Generic;
using System.Linq;
using System;
using OkOk.Data;
using OkOk.Models.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OkOkTest;

public class GuardianTest{
    [Fact]
    public async Task GuardianControllerIndex_SendGuardian_Guardian1(){
        //Arrange
        DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(options);
        var store = new Mock<IUserStore<GuardianApplicationUser>>();
        var usermanager = new Mock<UserManager<GuardianApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        Guid id1 = Guid.NewGuid();
        Guid id2 = Guid.NewGuid();
        Guid guardianId = Guid.NewGuid();
        GuardianApplicationUser guardian1 = new GuardianApplicationUser(){
            Id = guardianId.ToString(),
            FirstName = "Gerard",
            LastName = "A",
            Children = new List<ClientApplicationUser>(){
                new ClientApplicationUser(){
                    Id=id1.ToString(),
                    FirstName = "Leon",
                    LastName = "A",
                    OldEnough =true,
                    Address = new Address(){
                        HouseNumber = 1,
                        Street = "Straat",
                        City = "Delft",
                        ZipCode = "2121DW",
                        Country = "Nederland"
                    },
                    Received = new List<Message>(){
                        new Message(){
                            Content = "Hoi",
                            DateTime = DateTime.Now,
                            SupportGroup = new SupportGroup(){
                                Name = "Groep A",
                                Description = "Eerste groep"
                            },
                            SenderId = id1.ToString()
                            
                            
                        },
                        new Message(){
                            Content = "Hallo",
                            DateTime = DateTime.Now,
                            SupportGroup = new SupportGroup(){
                                Name= "Groep B",
                                Description = "Tweede groep"
                            },
                            SenderId = id1.ToString()
                        }
                    }
                },
                new ClientApplicationUser(){
                    Id = id2.ToString(),
                    FirstName = "Appel",
                    LastName = "A",
                    OldEnough = false,
                    Address = new Address(){
                        HouseNumber = 1,
                        Street = "Straat",
                        City = "Delft",
                        ZipCode = "2121DW",
                        Country = "Nederland"
                    },
                    Received = new List<Message>(){
                        new Message(){
                            Content = "Hoi",
                            DateTime = DateTime.Now,
                            SupportGroup = new SupportGroup(){
                                Name = "Groep A",
                                Description = "Eerste groep"
                            },
                            SenderId = id2.ToString()
                        },
                        new Message(){
                            Content = "Hallo",
                            DateTime = DateTime.Now,
                            SupportGroup = new SupportGroup(){
                                Name= "Groep B",
                                Description = "Tweede groep"
                            },
                            SenderId = id2.ToString()
                        }
                    }
                }
            }
        };
        c.GuardianApplicationUsers.Add(guardian1);
        c.SaveChanges();

        //usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.GuardianApplicationUsers.SingleAsync(g => g.Id == guardian1.Id).Id);
        usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.GuardianApplicationUsers.SingleAsync(it=>it.Id==guardian1.Id));
        GuardianController gc = new GuardianController(c,usermanager.Object);


        //Act
        var result =(ViewResult) await gc.Index();

        //Assert
        GuardianApplicationUser guardianResult = result.Model as GuardianApplicationUser;

        Xunit.Assert.NotNull(result);
        usermanager.Verify(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Xunit.Assert.Equal(guardian1.Id,  guardianResult.Id);
    }

    [Fact]
    public void GuardianControllerChildChatFrequency_returnsClient_ClientApplicationUser(){
        //Arrange
        DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(options);
        var store = new Mock<IUserStore<GuardianApplicationUser>>();
        var usermanager = new Mock<UserManager<GuardianApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        Guid id1 = Guid.NewGuid();
        Guid id2 = Guid.NewGuid();
        Guid guardianId = Guid.NewGuid();
        GuardianApplicationUser guardian1 = new GuardianApplicationUser(){
            Id = guardianId.ToString(),
            FirstName = "Gerard",
            LastName = "A",
            Children = new List<ClientApplicationUser>(){
                new ClientApplicationUser(){
                    Id=id1.ToString(),
                    FirstName = "Leon",
                    LastName = "A",
                    OldEnough =true,
                    Address = new Address(){
                        HouseNumber = 1,
                        Street = "Straat",
                        City = "Delft",
                        ZipCode = "2121DW",
                        Country = "Nederland"
                    },
                    Received = new List<Message>(){
                        new Message(){
                            Content = "Hoi",
                            DateTime = DateTime.Now,
                            SupportGroup = new SupportGroup(){
                                Name = "Groep A",
                                Description = "Eerste groep"
                            },
                            SenderId = id1.ToString()
                            
                            
                        },
                        new Message(){
                            Content = "Hallo",
                            DateTime = DateTime.Now,
                            SupportGroup = new SupportGroup(){
                                Name= "Groep B",
                                Description = "Tweede groep"
                            },
                            SenderId = id1.ToString()
                        }
                    }
                },
                new ClientApplicationUser(){
                    Id = id2.ToString(),
                    FirstName = "Appel",
                    LastName = "A",
                    OldEnough = false,
                    Address = new Address(){
                        HouseNumber = 1,
                        Street = "Straat",
                        City = "Delft",
                        ZipCode = "2121DW",
                        Country = "Nederland"
                    },
                    Received = new List<Message>(){
                        new Message(){
                            Content = "Hoi",
                            DateTime = DateTime.Now,
                            SupportGroup = new SupportGroup(){
                                Name = "Groep A",
                                Description = "Eerste groep"
                            },
                            SenderId = id2.ToString()
                        },
                        new Message(){
                            Content = "Hallo",
                            DateTime = DateTime.Now,
                            SupportGroup = new SupportGroup(){
                                Name= "Groep B",
                                Description = "Tweede groep"
                            },
                            SenderId = id2.ToString()
                        }
                    }
                }
            }
        };

        c.GuardianApplicationUsers.Add(guardian1);
        c.SaveChanges();

        //usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.GuardianApplicationUsers.Single(g => g.Id == guardian1.Id));
        usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.GuardianApplicationUsers.SingleAsync(it=>it.Id==guardian1.Id));
        GuardianController gc = new GuardianController(c, usermanager.Object);

        //Act
        var result =(ViewResult) gc.ChildChatFrequency(id1.ToString());

        //Assert
        ClientApplicationUser clientResult = result.Model as ClientApplicationUser;

        Xunit.Assert.NotNull(result);
        //usermanager.Verify(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Xunit.Assert.Equal(id1.ToString(),  clientResult.Id);
    }       
}