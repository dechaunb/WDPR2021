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
using System.Collections.Generic;

namespace OkOkTest;

public class DoctorTest
{

    [Fact]
    public async Task Index_In_DoctorController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<DoctorApplicationUser>>();
        var usermanager = new Mock<UserManager<DoctorApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
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

        c.AddRange(doctorOne);
        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.DoctorApplicationUsers.SingleAsync(it=>it.Id==doctorOne.Id));
        DoctorController doctorController = new DoctorController(c,usermanager.Object);

        //Act
        var sut = (await doctorController.Index()) as ViewResult;

        //Assert
        Assert.NotNull(sut);
        usermanager.Verify(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>()), Times.Once);

    }

    [Fact]
    public void Messages_In_DoctorController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore1").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<DoctorApplicationUser>>();
        var usermanager = new Mock<UserManager<DoctorApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        DoctorController doctorController = new DoctorController(c,usermanager.Object);

        //Act
        var sut = doctorController.Messages() as ViewResult;

        //Assert
        Assert.NotNull(sut);
    }

    [Fact]
    public void Appointments_In_DoctorController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore2").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<DoctorApplicationUser>>();
        var usermanager = new Mock<UserManager<DoctorApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        DoctorController doctorController = new DoctorController(c,usermanager.Object);

        //Act
        var sut = doctorController.Appointments() as ViewResult;

        //Assert
        Assert.NotNull(sut);
    }
    [Fact]
    public async Task CreateAppointment_In_DoctorController_TestAsync ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore2").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<DoctorApplicationUser>>();
        var usermanager = new Mock<UserManager<DoctorApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
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
            NormalizedUserName = "doctorone@okokapp.nl".ToUpper(),
            Treatments=new List<Treatment>()
        };
        c.Add(doctorOne);
        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.DoctorApplicationUsers.SingleAsync(it=>it==doctorOne));
        DoctorController doctorController = new DoctorController(c,usermanager.Object);

        //Act
        var sut = await doctorController.CreateAppointment() as ViewResult;

        //Assert
        Assert.NotNull(sut);
    }

    [Fact]
    public async Task GetAppointments_In_DoctorController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore3").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<DoctorApplicationUser>>();
        var usermanager = new Mock<UserManager<DoctorApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
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
            FirstName = "client",
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
            NormalizedUserName = "doctorone@okokapp.nl".ToUpper(),
            Treatments=new List<Treatment>()
        };
        Treatment treatmentCDOne1 = new Treatment()
        {
            Id = Guid.NewGuid(),
            DoctorId = doctorOne.Id,
            DoctorApplicationUser = doctorOne,
            ClientId = clientOne.Id,
            ClientApplicationUser = clientOne,
            DateTime = DateTime.Now,
            Description = "Intake"
        };
        doctorOne.Treatments.Add(treatmentCDOne1);
        c.AddRange(doctorOne,doctorOne,treatmentCDOne1);
        await c.SaveChangesAsync();
        
        usermanager.Setup(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns(doctorOne.Id);

        DoctorController doctorController = new DoctorController(c,usermanager.Object);

        //Act
        var sut = (await doctorController.GetAppointments()) as JsonResult;
        string res = JsonConvert.SerializeObject(sut.Value);    

        //Assert
        Assert.NotNull(sut);
        usermanager.Verify(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.True(res.Contains("Intake"));

    }
    [Fact]
    public async Task CreateAppointment_In_DoctorController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore3").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<DoctorApplicationUser>>();
        var usermanager = new Mock<UserManager<DoctorApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
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
            FirstName = "client",
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
            NormalizedUserName = "doctorone@okokapp.nl".ToUpper(),
            Treatments=new List<Treatment>()
        };
        c.AddRange(doctorOne,doctorOne);
        await c.SaveChangesAsync();
        
        usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.DoctorApplicationUsers.SingleAsync(it=>it==doctorOne));

        DoctorController doctorController = new DoctorController(c,usermanager.Object);
        Treatment treatment=new Treatment()
        {
            Id = Guid.NewGuid(),
            DoctorId = doctorOne.Id,
            DoctorApplicationUser = doctorOne,
            ClientId = clientOne.Id,
            ClientApplicationUser = clientOne,
            DateTime = DateTime.Now,
            Description = "Intake"
        };
        //Act
        var sut = (await doctorController.CreateAppointment(treatment)) as IActionResult;

        //Assert
        Assert.NotNull(sut);
        usermanager.Verify(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.True((await c.DoctorApplicationUsers.Include(it=>it.Treatments).SingleAsync(it=>it.Id==doctorOne.Id)).Treatments.Contains(treatment));

    }

}