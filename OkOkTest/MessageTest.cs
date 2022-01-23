using Xunit;
using OkOk;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using System;
using OkOk.Models.Identity;
using OkOk.Controllers;
using Microsoft.EntityFrameworkCore;
using OkOk.Data;
using System.Security.Claims;
using System.Threading.Tasks;
using OkOk.Models;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace OkOkTest;

public class MessageTest
{

    [Fact]
    public void Index_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        MessageController messageController = new MessageController(c,usermanager.Object);

        //Act
        var sut = messageController.Index() as ViewResult;

        //Assert
        Assert.NotNull(sut);
    }
    
    [Fact]
    public void Chats_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore1").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        MessageController messageController = new MessageController(c,usermanager.Object);

        var httpContext = new Mock<HttpContext>();
        httpContext.Setup(con => con.User.IsInRole(It.Is<string>(s => s.Equals("Doctor")))).Returns(true);

        var context = new ControllerContext(new ActionContext(httpContext.Object, new RouteData(), new ControllerActionDescriptor()));
        messageController.ControllerContext=context;

        //Act
        var sut = messageController.Chats() as IActionResult;

        //Assert
        Assert.NotNull(sut);
    }

    [Fact]
    public async Task Report_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore2").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        MessageController messageController = new MessageController(c,usermanager.Object);
        Guid id = Guid.NewGuid();
        ChatApplicationUser user = new ChatApplicationUser(){
            FirstName = "Angelo",
            LastName = "OkOk",
            UserName = "angelo@okokapp.nl",  
            Email = "angelo@okokapp.nl",  
            LockoutEnabled = false,  
            PhoneNumber = "1234567890",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            NormalizedEmail = "angelo@okokapp.nl".ToUpper(),
            NormalizedUserName = "angelo@okokapp.nl".ToUpper()
        };

        Message message = new Message{
            Id=id,
            SenderId=user.Id,
            DateTime=DateTime.Now,
            Content="Hoi"
        };
        c.AddRange(user, message);
        await c.SaveChangesAsync();

        //Act
        await messageController.Report("Niet bestaande Id");
        await messageController.Report(id.ToString());

        //Assert
        Assert.True(await c.Reports.AnyAsync(it=>it.MessageReport.MessageId==id));
        Assert.Equal(1,c.Reports.Count());
        
    }

    [Fact]
    public async Task GroupHub_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore3").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);

        ChatApplicationUser user = new ChatApplicationUser(){
            FirstName = "Angelo",
            LastName = "OkOk",
            UserName = "angelo@okokapp.nl",  
            Email = "angelo@okokapp.nl",  
            LockoutEnabled = false,  
            PhoneNumber = "1234567890",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            NormalizedEmail = "angelo@okokapp.nl".ToUpper(),
            NormalizedUserName = "angelo@okokapp.nl".ToUpper()
        };
        Guid id = Guid.NewGuid();
        SupportGroup group = new SupportGroup(){
            Id=id,
            Name="Group 1",
            Description="ADHD zelfhulpgroep",
            Received=new List<Message>(){new Message{
                Id=Guid.NewGuid(),
                SenderId=user.Id,
                GroupId=id,
                DateTime=DateTime.Now,
                Content="Hoi"
            }}
        };

        await c.AddRangeAsync(user,group);
        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.ChatApplicationUsers.SingleAsync(it=>it.Id==user.Id));
        MessageController messageController = new MessageController(c,usermanager.Object);

        //Act
        var sut = await messageController.GroupHub(group.Id.ToString()) as ViewResult;
        var sutNotFound = await messageController.GroupHub("non existing guid-string") as NotFoundResult;

        //Assert
        Assert.NotNull(sut); 
        Assert.NotNull(sutNotFound); 
        usermanager.Verify(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.Equal(group.Received,sut.ViewData["Messages"]);
        Assert.Equal(user,sut.ViewData["User"]);

    }

    [Fact]
    public async Task GetGroupChats_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore4").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        string id = Guid.NewGuid().ToString();
        ChatApplicationUser user = new ChatApplicationUser(){
            Id=id,
            FirstName = "Angelo",
            LastName = "OkOk",
            UserName = "angelo@okokapp.nl",  
            Email = "angelo@okokapp.nl",  
            LockoutEnabled = false,  
            PhoneNumber = "1234567890",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            NormalizedEmail = "angelo@okokapp.nl".ToUpper(),
            NormalizedUserName = "angelo@okokapp.nl".ToUpper(),
            SupportGroups= new List<SupportGroup>()
        };
        SupportGroup group = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 1",
            Description="ADHD zelfhulpgroep"
        };
        user.SupportGroups.Add(group);

        await c.AddRangeAsync(user,group);
        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns((await c.ChatApplicationUsers.SingleAsync(it=>it.Id==user.Id)).Id);
        MessageController messageController = new MessageController(c,usermanager.Object);

        //Act
        JsonResult sut = await messageController.GetGroupChats() as JsonResult;
        string res = JsonConvert.SerializeObject(sut.Value);    

        //Assert
        Assert.NotNull(sut); 
        usermanager.Verify(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.True(res.Contains(group.Id.ToString()));

    }

    [Fact]
    public async Task GetChats_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore5").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        string id = Guid.NewGuid().ToString();
        ChatApplicationUser user = new ChatApplicationUser(){
            Id=id,
            FirstName = "Angelo",
            LastName = "OkOk",
            UserName = "angelo@okokapp.nl",  
            Email = "angelo@okokapp.nl",  
            LockoutEnabled = false,  
            PhoneNumber = "1234567890",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            NormalizedEmail = "angelo@okokapp.nl".ToUpper(),
            NormalizedUserName = "angelo@okokapp.nl".ToUpper(),
            Received= new List<Message>()
        };
        ChatApplicationUser doctor = new ChatApplicationUser(){
            FirstName = "doctor",
            LastName = "OkOk",
            UserName = "doctor@okokapp.nl",  
            Email = "doctor@okokapp.nl",  
            LockoutEnabled = false,  
            PhoneNumber = "1234567890",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            NormalizedEmail = "doctor@okokapp.nl".ToUpper(),
            NormalizedUserName = "doctor@okokapp.nl".ToUpper(),
            Received= new List<Message>()
        };
        Message message = new Message{
            Id=Guid.NewGuid(),
            SenderId=doctor.Id,
            DateTime=DateTime.Now,
            Content="Hoi"
        };
        user.Received.Add(message);
        doctor.Received.Add(message);

        await c.AddRangeAsync(user,doctor);
        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns((await c.ChatApplicationUsers.SingleAsync(it=>it.Id==user.Id)).Id);
        MessageController messageController = new MessageController(c,usermanager.Object);

        //Act
        JsonResult sut = await messageController.GetChats() as JsonResult;
        string res = JsonConvert.SerializeObject(sut.Value);    

        //Assert
        Assert.NotNull(sut); 
        usermanager.Verify(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>()), Times.Exactly(2));
        Assert.True(res.Contains(doctor.UserName));

    }

    [Fact]
    public async Task NewGroupChat_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore6").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        string id = Guid.NewGuid().ToString();
        ChatApplicationUser user = new ChatApplicationUser(){
            Id=id,
            FirstName = "Angelo",
            LastName = "OkOk",
            UserName = "angelo@okokapp.nl",  
            Email = "angelo@okokapp.nl",  
            LockoutEnabled = false,  
            PhoneNumber = "1234567890",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            NormalizedEmail = "angelo@okokapp.nl".ToUpper(),
            NormalizedUserName = "angelo@okokapp.nl".ToUpper(),
            SupportGroups= new List<SupportGroup>()
        };
        SupportGroup group = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 1",
            Description="ADHD zelfhulpgroep"
        };
        SupportGroup group2 = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 2",
            Description="ADD zelfhulpgroep"
        };
        user.SupportGroups.Add(group2);

        var httpContext = new Mock<HttpContext>();
        httpContext.Setup(con => con.User.IsInRole(It.Is<string>(s => s.Equals("Doctor")))).Returns(true);

        var context = new ControllerContext(new ActionContext(httpContext.Object, new RouteData(), new ControllerActionDescriptor()));


        await c.AddRangeAsync(user,group, group2);
        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns((await c.ChatApplicationUsers.SingleAsync(it=>it.Id==user.Id)).Id);
        MessageController messageController = new MessageController(c,usermanager.Object);
        messageController.ControllerContext = context;

        //Act
        var sut = (await messageController.NewGroupChat(null,"",""))as IActionResult;

        //Assert
        Assert.NotNull(sut); 

        usermanager.Verify(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.True(((sut as ViewResult).ViewData.Model as PaginatedList<SupportGroup>).Any(it=>it.Id==group.Id));
        Assert.False(((sut as ViewResult).ViewData.Model as PaginatedList<SupportGroup>).Any(it=>it.Id==group2.Id));

    }
    [Fact]
    public async Task NewGroupChat_Post_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore7").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);
        string id = Guid.NewGuid().ToString();
        ChatApplicationUser user = new ChatApplicationUser(){
            Id=id,
            FirstName = "Angelo",
            LastName = "OkOk",
            UserName = "angelo@okokapp.nl",  
            Email = "angelo@okokapp.nl",  
            LockoutEnabled = false,  
            PhoneNumber = "1234567890",
            EmailConfirmed = true,
            PhoneNumberConfirmed = true,
            NormalizedEmail = "angelo@okokapp.nl".ToUpper(),
            NormalizedUserName = "angelo@okokapp.nl".ToUpper(),
            SupportGroups= new List<SupportGroup>()
        };
        SupportGroup group = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 1",
            Description="ADHD zelfhulpgroep"
        };
        SupportGroup group2 = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 2",
            Description="ADD zelfhulpgroep"
        };
        user.SupportGroups.Add(group);
        var initialcount = user.SupportGroups.Count();

        await c.AddRangeAsync(user,group, group2);
        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns((await c.ChatApplicationUsers.SingleAsync(it=>it.Id==user.Id)).Id);
        MessageController messageController = new MessageController(c,usermanager.Object);

        //Act
        var sut = (await messageController.NewGroupChat(group2.Id.ToString())) as IActionResult;

        //Assert
        Assert.NotNull(sut); 

        usermanager.Verify(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.Equal(1,user.SupportGroups.Count()-initialcount);
        Assert.True(user.SupportGroups.Any(it=>it==group2));

    }

    [Fact]
    public async Task Hub_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore8").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);

        ChatApplicationUser client = new ChatApplicationUser(){
                FirstName = "client",
                LastName = "OkOk",
                UserName = "client@okokapp.nl",  
                Email = "client@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "client@okokapp.nl".ToUpper(),
                NormalizedUserName = "client@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };
        ChatApplicationUser doctor = new ChatApplicationUser(){
                FirstName = "doctor",
                LastName = "OkOk",
                UserName = "doctor@okokapp.nl",  
                Email = "doctor@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "doctor@okokapp.nl".ToUpper(),
                NormalizedUserName = "doctor@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };
        Message message = new Message{
            Id=Guid.NewGuid(),
            SenderId=doctor.Id,
            DateTime=DateTime.Now,
            Content="Hoi"
        };

        client.Received.Add(message);
        doctor.Received.Add(message);

        await c.AddRangeAsync(message,client,doctor);
        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.ChatApplicationUsers.SingleAsync(it=>it.Id==client.Id));
        usermanager.Setup(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns((await c.ChatApplicationUsers.SingleAsync(it=>it.Id==client.Id)).Id);
        MessageController messageController = new MessageController(c,usermanager.Object);

        //Act
        var sut = await messageController.Hub(doctor.UserName) as ViewResult;
        var sutNotFound = await messageController.Hub("non existing username") as NotFoundResult;

        //Assert
        Assert.NotNull(sut); 
        Assert.NotNull(sutNotFound); 
        usermanager.Verify(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>()), Times.Once);
        usermanager.Verify(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.Equal(client.Received,sut.ViewData["Messages"]);
        Assert.Equal(client,sut.ViewData["User"]);

    }

    [Fact]
    public async Task GroupMessageCreate_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore9").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);

        ChatApplicationUser client = new ChatApplicationUser(){
                FirstName = "client",
                LastName = "OkOk",
                UserName = "client@okokapp.nl",  
                Email = "client@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "client@okokapp.nl".ToUpper(),
                NormalizedUserName = "client@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };
        SupportGroup group = new SupportGroup(){
            Id=Guid.NewGuid(),
            Name="Group 1",
            Description="ADHD zelfhulpgroep"
        };

        await c.AddRangeAsync(group,client);
        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.ChatApplicationUsers.SingleAsync(it=>it.Id==client.Id));
        usermanager.Setup(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns((await c.ChatApplicationUsers.SingleAsync(it=>it.Id==client.Id)).Id);
        MessageController messageController = new MessageController(c,usermanager.Object);

        string uniquestring = "unieke string";
        //Act

        await messageController.GroupMessageCreate(
            new ChatViewModel(){
                contentstring=uniquestring, 
                sender= client.UserName,
                receiver= group.Id.ToString()
            }
        );

        //Assert
        usermanager.Verify(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.True(group.Received.Any(it=>it.Content==uniquestring));
    }
    [Fact]
    public async Task PersonalMessageCreate_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore10").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);

        ChatApplicationUser client = new ChatApplicationUser(){
                FirstName = "client",
                LastName = "OkOk",
                UserName = "client1@okokapp.nl",  
                Email = "client@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "client@okokapp.nl".ToUpper(),
                NormalizedUserName = "client@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };
        ChatApplicationUser doctor = new ChatApplicationUser(){
                FirstName = "doctor",
                LastName = "OkOk",
                UserName = "doctor@okokapp.nl",  
                Email = "doctor@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "doctor@okokapp.nl".ToUpper(),
                NormalizedUserName = "doctor@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };


        await c.AddRangeAsync(doctor,client);
        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>())).Returns(c.ChatApplicationUsers.SingleAsync(it=>it.Id==client.Id));
        usermanager.Setup(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns((await c.ChatApplicationUsers.SingleAsync(it=>it.Id==client.Id)).Id);
        MessageController messageController = new MessageController(c,usermanager.Object);

        string uniquestring = "unieke string"+Guid.NewGuid().ToString();
        //Act

        await messageController.PersonalMessageCreate(
            new ChatViewModel(){
                contentstring=uniquestring, 
                sender= client.UserName,
                receiver= doctor.UserName
            }
        );

        //Assert
        usermanager.Verify(it=>it.GetUserAsync(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.True(doctor.Received.Any(it=>it.Content==uniquestring&&it.Sender== client));
        Assert.True(client.Received.Any(it=>it.Content==uniquestring&&it.Sender== client));
    }    
    [Fact]
    public async Task NewPrivateChat_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore11").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);

        ChatApplicationUser client = new ChatApplicationUser(){
                Id=Guid.NewGuid().ToString(),
                FirstName = "client",
                LastName = "OkOk",
                UserName = "client@okokapp.nl",  
                Email = "client@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "client@okokapp.nl".ToUpper(),
                NormalizedUserName = "client@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };
        ChatApplicationUser doctor = new ChatApplicationUser(){
                Id=Guid.NewGuid().ToString(),
                FirstName = "doctor",
                LastName = "OkOk",
                UserName = "doctor@okokapp.nl",  
                Email = "doctor@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "doctor@okokapp.nl".ToUpper(),
                NormalizedUserName = "doctor@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };
        ChatApplicationUser doctor2 = new ChatApplicationUser(){
                Id=Guid.NewGuid().ToString(),
                FirstName = "doctor2",
                LastName = "OkOk",
                UserName = "doctor2@okokapp.nl",  
                Email = "doctor2@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "doctor2@okokapp.nl".ToUpper(),
                NormalizedUserName = "doctor2@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };
        Message message = new Message{
            Id=Guid.NewGuid(),
            SenderId=doctor.Id,
            DateTime=DateTime.Now,
            Content="Hoi"
        };

        client.Received.Add(message);
        doctor.Received.Add(message);

        await c.AddRangeAsync(message,client,doctor, doctor2);

        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns((await c.ChatApplicationUsers.SingleAsync(it=>it.Id==client.Id)).Id);
        MessageController messageController = new MessageController(c,usermanager.Object);

        //Act

        var sut = await messageController.NewPrivateChat() as ViewResult;

        //Assert
        Assert.NotNull(sut);
        IEnumerable<ChatApplicationUser> lijst = (sut.ViewData["List"] as SelectList).Items as IEnumerable<ChatApplicationUser>;
        usermanager.Verify(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.Equal(1,lijst.Count());
        Assert.True(lijst.Any(it=>it== doctor2));
    }    
    [Fact]
    public async Task GetChatMessages_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore12").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);

        ChatApplicationUser client = new ChatApplicationUser(){
                Id=Guid.NewGuid().ToString(),
                FirstName = "client",
                LastName = "OkOk",
                UserName = "client@okokapp.nl",  
                Email = "client@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "client@okokapp.nl".ToUpper(),
                NormalizedUserName = "client@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };
        ChatApplicationUser doctor = new ChatApplicationUser(){
                Id=Guid.NewGuid().ToString(),
                FirstName = "doctor",
                LastName = "OkOk",
                UserName = "doctor@okokapp.nl",  
                Email = "doctor@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "doctor@okokapp.nl".ToUpper(),
                NormalizedUserName = "doctor@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };
        Message message = new Message{
            Id=Guid.NewGuid(),
            SenderId=doctor.Id,
            DateTime=DateTime.Now,
            Content="Hoi"
        };
        Message message2 = new Message{
            Id=Guid.NewGuid(),
            SenderId=client.Id,
            DateTime=DateTime.Now,
            Content="Hoi"
        };

        client.Received.Add(message);
        client.Received.Add(message2);
        doctor.Received.Add(message);

        await c.AddRangeAsync(message,message2,client,doctor);

        await c.SaveChangesAsync();

        usermanager.Setup(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>())).Returns((await c.ChatApplicationUsers.SingleAsync(it=>it.Id==client.Id)).Id);
        MessageController messageController = new MessageController(c,usermanager.Object);

        //Act

        var sut = await messageController.GetChatMessages(doctor.UserName) as List<Message>;

        //Assert
        Assert.NotNull(sut);
        usermanager.Verify(it=>it.GetUserId(It.IsAny<ClaimsPrincipal>()), Times.Once);
        Assert.Equal(1,sut.Count());
    }    
    [Fact]
    public async Task NewPrivateChat_Post_In_MessageController_Test ()
    {
        //Arrange
        DbContextOptions dbContextOptions = new DbContextOptionsBuilder().UseInMemoryDatabase("OkDataStore13").Options;
        var c = new ApplicationDbContext(dbContextOptions);
        var store = new Mock<IUserStore<ChatApplicationUser>>();
        var usermanager = new Mock<UserManager<ChatApplicationUser>>(store.Object, null, null, null, null, null, null, null, null);

        ChatApplicationUser client = new ChatApplicationUser(){
                Id=Guid.NewGuid().ToString(),
                FirstName = "client",
                LastName = "OkOk",
                UserName = "client@okokapp.nl",  
                Email = "client@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "client@okokapp.nl".ToUpper(),
                NormalizedUserName = "client@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };
        ChatApplicationUser doctor = new ChatApplicationUser(){
                Id=Guid.NewGuid().ToString(),
                FirstName = "doctor",
                LastName = "OkOk",
                UserName = "doctor@okokapp.nl",  
                Email = "doctor@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "doctor@okokapp.nl".ToUpper(),
                NormalizedUserName = "doctor@okokapp.nl".ToUpper(),
                Received= new List<Message>()
        };

        await c.AddRangeAsync(client,doctor);

        await c.SaveChangesAsync();

        MessageController messageController = new MessageController(c,usermanager.Object);

        //Act
        var sut = messageController.NewPrivateChat(doctor.UserName) as IActionResult;

        //Assert
        Assert.NotNull(sut);
    }    
}