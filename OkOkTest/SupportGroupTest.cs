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
using System.Threading.Tasks;

namespace OkOkTest;

public class SupportGroupTest{

    [Fact]
    public async Task Index_In_SupportGroupController_Test(){
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore1").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        SupportGroupController supportGroupController = new SupportGroupController(c);

        //Act
        var sut = await supportGroupController.Index() as ViewResult;

        //Assert
        Assert.NotNull(sut);
    }

    [Fact]
    public async Task Details_In_SupportGroupController_Test(){
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore2").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        SupportGroupController supportGroupController = new SupportGroupController(c);

        SupportGroup group = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 1",
            Description="ADHD zelfhulpgroep"
        };
        c.Add(group);
        await c.SaveChangesAsync();

        //Act
        var sut = await supportGroupController.Index() as ViewResult;

        //Assert
        Assert.NotNull(sut);
        Assert.True((sut.ViewData.Model as List<SupportGroup>).Any(it=>it==group));
    }

    [Fact]
    public async Task Edit_In_SupportGroupController_Test(){
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore3").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        SupportGroupController supportGroupController = new SupportGroupController(c);

        SupportGroup group = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 1",
            Description="ADHD zelfhulpgroep"
        };
        c.Add(group);
        await c.SaveChangesAsync();

        //Act
        var sut = await supportGroupController.Edit(group.Id) as ViewResult;

        //Assert
        Assert.NotNull(sut);
        Assert.True((sut.ViewData.Model as SupportGroup)==group);

    }


    [Fact]
    public async Task Edit_Post_In_SupportGroupController_Test(){
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore4").Options;
        var c = new ApplicationDbContext(dbContextOptions);

        SupportGroup group = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 1",
            Description="ADHD zelfhulpgroep"
        };
        await c.AddAsync(group);
        await c.SaveChangesAsync();

        SupportGroup group1 = new SupportGroup(){
            Id=group.Id, 
            Name="Group 1 test",
            Description="ADHD zelfhulpgroep"
        };
        using (var resultcontext = new ApplicationDbContext(dbContextOptions)){
            SupportGroupController supportGroupController = new SupportGroupController(resultcontext);

            //Act
            var sut = await supportGroupController.Edit(group.Id,group1) as IActionResult;

            //Assert
            Assert.NotNull(sut);
            Assert.Equal(group1.Name,resultcontext.SupportGroups.Single(it=>it.Id==group.Id).Name);
        }

    }

    [Fact]
    public void Create_In_SupportGroupController_Test(){
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore5").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        SupportGroupController supportGroupController = new SupportGroupController(c);

        //Act
        var sut = supportGroupController.Create() as IActionResult;

        //Assert
        Assert.NotNull(sut);

    }
    [Fact]
    public async Task Create_Post_In_SupportGroupController_Test(){
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore6").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        SupportGroupController supportGroupController = new SupportGroupController(c);

        SupportGroup group = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 1",
            Description="ADHD zelfhulpgroep"
        };

        //Act
        var sut = await supportGroupController.Create(group) as IActionResult;

        //Assert
        Assert.NotNull(sut);
        Assert.True(c.SupportGroups.Any(it=>it==group));

    }
    [Fact]
    public async Task Delete_In_SupportGroupController_Test(){
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore7").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        SupportGroupController supportGroupController = new SupportGroupController(c);

        SupportGroup group = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 1",
            Description="ADHD zelfhulpgroep"
        };
        c.Add(group);
        await c.SaveChangesAsync();

        //Act
        ViewResult? sut = await supportGroupController.Delete(group.Id) as ViewResult;

        //Assert
        Assert.NotNull(sut);
        Assert.Equal(sut.ViewData.Model,group);

    }
    [Fact]
    public async Task DeleteConfirmed_In_SupportGroupController_Test(){
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore8").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        SupportGroupController supportGroupController = new SupportGroupController(c);

        SupportGroup group = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 1",
            Description="ADHD zelfhulpgroep"
        };
        c.Add(group);
        await c.SaveChangesAsync();

        //Act
        var sut = await supportGroupController.DeleteConfirmed(group.Id) as IActionResult;

        //Assert
        Assert.NotNull(sut);
        Assert.False(c.SupportGroups.Any(it=>it==group));

    }

}
