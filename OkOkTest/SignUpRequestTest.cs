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

public class SignUpRequestTest{
    [Fact]
    public async Task SignUpController_Create(){
        //Arrange
        DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(options);
        SignUpRequestController sc = new SignUpRequestController(c);

        Guid id1 = Guid.NewGuid();
        Guid id2 = Guid.NewGuid();
        ClientApplicationUser client1 = new ClientApplicationUser(){
            Id= id1.ToString(),
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
        };
        DoctorApplicationUser doctor1 = new DoctorApplicationUser(){
            Id= id2.ToString(),
            FirstName = "Dokter",
            LastName = "Een",
            Specialism = "ADHD"
        };
        c.Add(client1);
        c.Add(doctor1);
        c.SaveChanges();

        //Act
        await sc.CreateRequestAsync(client1);

        //Assert
        Xunit.Assert.Equal(1, c.SignUpRequests.Count());
        Xunit.Assert.True(c.SignUpRequests.Any(s => s.ClientApplicationUser == client1));
    }

    [Fact]
    public async Task SignUpRequestController_Delete(){
        //Arrange
        DbContextOptions options = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(options);
        SignUpRequestController sc = new SignUpRequestController(c);

        Guid id1 = Guid.NewGuid();
        Guid id2 = Guid.NewGuid();
        Guid signupId = Guid.NewGuid();
        ClientApplicationUser client1 = new ClientApplicationUser(){
            Id= id1.ToString(),
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
        };
        DoctorApplicationUser doctor1 = new DoctorApplicationUser(){
            Id= id2.ToString(),
            FirstName = "Dokter",
            LastName = "Een",
            Specialism = "ADHD"
        };

        SignUpRequest request1 = new SignUpRequest(){
            Id = signupId,
            Handled = false,
            ClientId = client1.Id,
            ClientApplicationUser = client1,
            DoctorId = doctor1.Id,
            DoctorApplicationUser = doctor1
        };
        c.Add(client1);
        c.Add(doctor1);
        c.Add(request1);
        c.SaveChanges();

        //Act
        Xunit.Assert.Equal(2, c.SignUpRequests.Count());
        await sc.DeleteConfirmed(signupId);

        //Assert
        Xunit.Assert.Equal(1, c.SignUpRequests.Count());
    }
}