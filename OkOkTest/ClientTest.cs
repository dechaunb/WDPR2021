using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System;
using OkOk.Models.Identity;
using OkOk.Controllers;
using Microsoft.EntityFrameworkCore;
using OkOk.Data;
using System.Security.Claims;
using System.Threading.Tasks;
using OkOk.Models;
using Newtonsoft.Json;

namespace OkOkTest;

public class ClientTest
{

    [Fact]
    public async Task Index_In_ClientController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ClientApplicationUser>>();
        var usermanager = new Mock<UserManager<ClientApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        Address address = new Address()
        {
            Id = Guid.NewGuid(),
            Street = "Dorpsstraat",
            City = "Dorp",
            ZipCode = "1234AB",
            HouseNumber = 1,
            Country = "Nederland"
        };
        ClientApplicationUser clientOne = new ClientApplicationUser()
        {
            FirstName = "Client",
            LastName = "One",
            UserName = "clientone@okokapp.nl",  
            Email = "clientone@okokapp.nl",  
            LockoutEnabled = false,  
            PhoneNumber = "1234567890",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            AddressId = address.Id,
            NormalizedEmail = "clientone@okokapp.nl".ToUpper(),
            NormalizedUserName = "clientone@okokapp.nl".ToUpper()
        };

        c.AddRange(clientOne);
        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.ClientApplicationUsers.SingleAsync(it=>it.Id==clientOne.Id));
        ClientController clientController = new ClientController(c,usermanager.Object);

        //Act
        var sut = (await clientController.Index()) as ViewResult;

        //Assert
        Assert.NotNull(sut);
        usermanager.Verify(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>()), Times.Once);

    }

    [Fact]
    public void Messages_In_ClientController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore1").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ClientApplicationUser>>();
        var usermanager = new Mock<UserManager<ClientApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        ClientController clientController = new ClientController(c,usermanager.Object);

        //Act
        var sut = clientController.Messages() as ViewResult;

        //Assert
        Assert.NotNull(sut);
    }

    [Fact]
    public void Appointments_In_ClientController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore2").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ClientApplicationUser>>();
        var usermanager = new Mock<UserManager<ClientApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        ClientController clientController = new ClientController(c,usermanager.Object);

        //Act
        var sut = clientController.Appointments() as ViewResult;

        //Assert
        Assert.NotNull(sut);
    }

    [Fact]
    public async Task GetAppointments_In_ClientController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore3").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ClientApplicationUser>>();
        var usermanager = new Mock<UserManager<ClientApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        Address address = new Address()
        {
            Id = Guid.NewGuid(),
            Street = "Dorpsstraat",
            City = "Dorp",
            ZipCode = "1234AB",
            HouseNumber = 1,
            Country = "Nederland"
        };
        ClientApplicationUser clientOne = new ClientApplicationUser()
        {
            FirstName = "Client",
            LastName = "One",
            UserName = "clientone@okokapp.nl",  
            Email = "clientone@okokapp.nl",  
            LockoutEnabled = false,  
            PhoneNumber = "1234567890",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            AddressId = address.Id,
            NormalizedEmail = "clientone@okokapp.nl".ToUpper(),
            NormalizedUserName = "clientone@okokapp.nl".ToUpper()
        };
        DoctorApplicationUser doctorOne = new DoctorApplicationUser()  
        {   
            FirstName = "Doctor",
            LastName = "One",
            UserName = "doctorone@okokapp.nl",  
            Email = "doctorone@okokapp.nl",  
            LockoutEnabled = false,  
            PhoneNumber = "1234567890",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            Specialism = "Autisme",
            NormalizedEmail = "doctorone@okokapp.nl".ToUpper(),
            NormalizedUserName = "doctorone@okokapp.nl".ToUpper()
        };
        Treatment treatmentCDOne1 = new Treatment()
        {
            Id = Guid.NewGuid(),
            DoctorId = doctorOne.Id,
            ClientId = clientOne.Id,
            DateTime = DateTime.Now,
            Description = "Intake"
        };
        c.AddRange(clientOne,doctorOne,treatmentCDOne1);
        await c.SaveChangesAsync();
        
        usermanager.Setup(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns(clientOne.Id);

        ClientController clientController = new ClientController(c,usermanager.Object);

        //Act
        var sut = (await clientController.GetAppointments()) as JsonResult;
        string res = JsonConvert.SerializeObject(sut.Value);    

        //Assert
        Assert.NotNull(sut);
        usermanager.Verify(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.True(res.Contains("Intake"));

    }

}