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

namespace OkOkTest;

public class UnitTest1
{
    //AdminController
    [Fact]
    public void AdminControllerIndex_ReturnsDoctorList_DoctorList()
    {
        //Arrange
        DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(options);
        AdminController acon = new AdminController(null, null, c, null);
        DoctorApplicationUser doctor1 = new DoctorApplicationUser(){
            FirstName = "Dokter",
            LastName = "Een",
            Email = "DokterEen@OkOkApp.nl",
            Specialism = "ADHD"
        };
        DoctorApplicationUser doctor2 = new DoctorApplicationUser(){
            FirstName = "Dokter",
            LastName = "Twee",
            Email = "DokterTwee@OkOkApp.nl",
            Specialism = "ADHD"
        };
        c.DoctorApplicationUsers.Add(doctor1);
        c.DoctorApplicationUsers.Add(doctor2);
        c.SaveChanges();

        //Act
        var DoctorsListResult = (ViewResult)acon.Index(1, 1, 1, null);

        //Assert
        Xunit.Assert.Equal(2, DoctorsListResult.ViewData.Count());
    }

    [Fact]
    public void AdminControllerIndex_FillViewBagAllClients_ViewBagDataFilled()
    {
        //Arrange
        DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(options);
        AdminController acon = new AdminController(null, null, c, null);
        ClientApplicationUser client1 =  new ClientApplicationUser(){
            FirstName = "Client1",
            LastName = "Een",
            Email = "Client1@OkOkApp.nl",
            Address = new Address(){
                HouseNumber = 1,
                Street = "Pr. Beatrixlaan",
                City = "Delft",
                ZipCode = "2927AB",
                Country = "Nederland"
            },

        };
        ClientApplicationUser client2 =  new ClientApplicationUser(){
            FirstName = "Client2",
            LastName = "Twee",
            Email = "Client2@OkOkApp.nl",
            Address = new Address(){
                HouseNumber = 1,
                Street = "Pr. Beatrixlaan",
                City = "Delft",
                ZipCode = "2927AB",
                Country = "Nederland"
            },
        };
        c.ClientApplicationUsers.Add(client1);
        c.ClientApplicationUsers.Add(client2);
        c.SaveChanges();

        //Act
        var result = (ViewResult)acon.Index(1,1,1, null);

        //Assert
        List<ClientApplicationUser>? clientList = result.ViewData["AllClients"] as List<ClientApplicationUser>;
        Xunit.Assert.Equal(2, clientList.Count()); 
    }

    [Fact]
    public void AdminControllerIndex_FillViewBagSumReportList_ViewBagDataFilled()
    {
        //Arrange
        DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(options);
        AdminController acon = new AdminController(null, null, c, null);
        ClientApplicationUser client1 =  new ClientApplicationUser(){
            FirstName = "Client1",
            LastName = "Een",
            Email = "Client1@OkOkApp.nl",
            Address = new Address(){
                HouseNumber = 1,
                Street = "Pr. Beatrixlaan",
                City = "Delft",
                ZipCode = "2927AB",
                Country = "Nederland"
            },

        };
        Report report1 = new Report(){
            MessageReport = new MessageReport(){
                Message = new Message(){
                    Content = "Sukkel",
                    DateTime = DateTime.Now,
                    Sender = client1
                }
            }
        };
        Report report2 = new Report(){
            MessageReport = new MessageReport(){
                Message = new Message(){
                    Content = "Idioot",
                    DateTime = DateTime.Now,
                    Sender = client1
                }
            }
        };
        c.ClientApplicationUsers.Add(client1);
        c.Reports.Add(report1);
        c.Reports.Add(report2);
        c.SaveChanges();
        Console.WriteLine(c.Reports.Select(r => r.Id).First());

        //Act
        var result = (ViewResult)acon.Index(1,1,1, null);

        //Assert
        List<SummarisedReport>? reportList = result.ViewData["UnfinishedReports"] as List<SummarisedReport>;
        Xunit.Assert.Equal(2, reportList.Count()); 
        //Xunit.Assert.Equal(" ", c.Reports.Select(r => r.Id).First().ToString());
    }

    //BlockClient test
    [Fact] 
    public void AdminControllerBlockUser_BlockClient_Blocked()
    {
        //Arrange
        DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(options);
        
        ClientApplicationUser client1 =  new ClientApplicationUser(){
            FirstName = "Client1",
            LastName = "Een",
            Email = "Client1@OkOkApp.nl",
            Address = new Address(){
                HouseNumber = 1,
                Street = "Pr. Beatrixlaan",
                City = "Delft",
                ZipCode = "2927AB",
                Country = "Nederland"
            },

        };
        Report report1 = new Report(){
            MessageReport = new MessageReport(){
                Message = new Message(){
                    Content = "Sukkel",
                    DateTime = DateTime.Now,
                    Sender = client1
                }
            }
        };

        c.ClientApplicationUsers.Add(client1);
        c.Reports.Add(report1);
        c.SaveChanges();

        var store = new Mock<IUserStore<ApplicationUser>>();
        var usermanager = new Mock<UserManager<ApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        usermanager.Setup(m => m.FindByIdAsync(It.IsAny<string>())).Returns(c.ApplicationUsers.FirstAsync());

        AdminController acon = new AdminController(usermanager.Object, null, c, null);

        string uId = c.Reports.Where(r => r.MessageReport.Message.Content == "Sukkel").Select(r => r.MessageReport.Message.Sender.Id).First();
        string reason = "Slecht taalgebruik";
        Guid messageId = (Guid) c.Reports.Where(r => r.MessageReport.Message.Content == "Sukkel").Select(r => r.MessageReport.MessageId).FirstOrDefault();

        //Act
        acon.BlockUser(uId, reason, messageId);

        //Assert
        Xunit.Assert.True(c.ClientApplicationUsers.Select(cl => cl.LockoutEnabled).First());
        Xunit.Assert.Equal("Cliënt geblokkeerd" ,acon.ViewData["BlockMeldingInhoud"]);
        Xunit.Assert.Equal(reason ,c.ClientApplicationUsers.Where(cl => cl.FirstName == "Client1").Select(cl => cl.LockedOutReason).First());
    }

    //DeblockClient
    [Fact] 
    public async void AdminControllerDeBlockUser_DeBlockClient_DeBlocked()
    {
        //Arrange
        DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(options);
        
        ClientApplicationUser client1 =  new ClientApplicationUser(){
            FirstName = "Client1",
            LastName = "Een",
            Email = "Client1@OkOkApp.nl",
            Address = new Address(){
                HouseNumber = 1,
                Street = "Pr. Beatrixlaan",
                City = "Delft",
                ZipCode = "2927AB",
                Country = "Nederland"
            },

        };
        Report report1 = new Report(){
            MessageReport = new MessageReport(){
                Message = new Message(){
                    Content = "Sukkel",
                    DateTime = DateTime.Now,
                    Sender = client1
                }
            }
        };
        c.ClientApplicationUsers.Add(client1);
        c.Reports.Add(report1);
        c.SaveChanges();

         var store = new Mock<IUserStore<ApplicationUser>>();
        var usermanager = new Mock<UserManager<ApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        usermanager.Setup(m => m.FindByIdAsync(It.IsAny<string>())).Returns(c.ApplicationUsers.FirstAsync());

        AdminController acon = new AdminController(usermanager.Object, null, c, null);


        string uId = c.Reports.Where(r => r.MessageReport.Message.Content == "Sukkel").Select(r => r.MessageReport.Message.SenderId).First();
        string reason = "Slecht taalgebruik";
        Guid messageId = (Guid) c.Reports.Where(r => r.MessageReport.Message.Content == "Sukkel").Select(r => r.MessageReport.MessageId).FirstOrDefault();

        //Act
        acon.BlockUser(uId, reason, messageId);
        await acon.DeBlockClient(uId);

        //Assert
        Xunit.Assert.False(client1.LockoutEnabled);
    }
    //DoctorDetails
    [Fact]
    public void AdminControllerDoctorDetails_ShowDoctorTreatments_SendTreatments()
    {
        //Arrange
        DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(options);
        AdminController acon = new AdminController(null, null, c, null);

        DoctorApplicationUser d1 = new DoctorApplicationUser(){
            FirstName = "Dokter",
                LastName = "Een",
                Email = "DokterEen@OkOkApp.nl",
                Specialism = "ADHD",
        };
        Treatment t1 = new Treatment(){
            DateTime = DateTime.Now,
            Description = " ",
            ClientApplicationUser = new ClientApplicationUser(){
                FirstName = "Client1",
                LastName = "Een",
                Email = "Client1@OkOkApp.nl",
                Address = new Address(){
                    HouseNumber = 1,
                    Street = "Pr. Beatrixlaan",
                    City = "Delft",
                    ZipCode = "2927AB",
                    Country = "Nederland"
                },
            },
            DoctorApplicationUser = d1
        };
        
        c.DoctorApplicationUsers.Add(d1);
        c.Treatments.Add(t1);
        c.SaveChanges();

        //Act
        string id = c.DoctorApplicationUsers.Select(d => d.Id).First();
        
        var result = (ViewResult) acon.DoctorDetails(id ,1);

        //Assert
        Xunit.Assert.Equal(1, result.ViewData.Count());
    }   
}