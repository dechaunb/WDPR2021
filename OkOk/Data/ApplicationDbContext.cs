using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using OkOk.Models;
using OkOk.Models.Identity;
using OkOk.Interfaces;
using System.Globalization;

namespace OkOk.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        //Models.Identity
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ChatApplicationUser> ChatApplicationUsers { get; set; }
        public DbSet<ClientApplicationUser> ClientApplicationUsers { get; set; }
        public DbSet<DoctorApplicationUser> DoctorApplicationUsers { get; set; }
        public DbSet<GuardianApplicationUser> GuardianApplicationUsers { get; set; }

        //Models
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MessageReport> MessageReports { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SignUpRequest> SignUpRequests { get; set; }
        public DbSet<SupportGroup> SupportGroups { get; set; }
        public DbSet<Treatment> Treatments { get; set; }
        
        public ApplicationDbContext (DbContextOptions options)
            : base(options)
        {

        }

        // public ApplicationDbContext(DbContextOptions options) : base(options)
        // {
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);  

            

            //Relations

            //Address
            modelBuilder.Entity<ClientApplicationUser>()
                        .HasOne(client => client.Address)
                        .WithOne(address => address.ClientApplicationUser)
                        .HasForeignKey<ClientApplicationUser>(address => address.AddressId)
                        .OnDelete(DeleteBehavior.NoAction);

            //Treatment
            modelBuilder.Entity<Treatment>()
                        .HasOne(treatment => treatment.ClientApplicationUser)
                        .WithMany(client => client.Treatments)
                        .HasForeignKey(treatment => treatment.ClientId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Treatment>()
                        .HasOne(treatment => treatment.DoctorApplicationUser)
                        .WithMany(doctor => doctor.Treatments)
                        .HasForeignKey(treatment => treatment.DoctorId)
                        .OnDelete(DeleteBehavior.NoAction);

            //MessageReport
            modelBuilder.Entity<MessageReport>()
                        .HasKey(composite => new { composite.MessageId, composite.ReportId});

            modelBuilder.Entity<MessageReport>()
                        .HasOne(mreport => mreport.Message)
                        .WithMany(message => message.MessageReports)
                        .HasForeignKey(mreport => mreport.MessageId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MessageReport>()
                        .HasOne(mreport => mreport.Report)
                        .WithOne(report => report.MessageReport)
                        .HasForeignKey<MessageReport>(mreport => mreport.ReportId)
                        .OnDelete(DeleteBehavior.NoAction);

            //SignUpRequest
            modelBuilder.Entity<ClientApplicationUser>()
                        .HasOne(client => client.SignUpRequest)
                        .WithOne(signup => signup.ClientApplicationUser)
                        .HasForeignKey<SignUpRequest>(signup => signup.ClientId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SignUpRequest>()
                        .HasOne(signup => signup.DoctorApplicationUser)
                        .WithMany(doctor => doctor.SignUpRequests)
                        .HasForeignKey(signup => signup.DoctorId)
                        .OnDelete(DeleteBehavior.NoAction);

            //Message
            modelBuilder.Entity<Message>()
                        .HasOne(message => message.Sender)
                        .WithMany(chatuser => chatuser.Sent)
                        .HasForeignKey(message => message.SenderId)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Message>()
                        .HasOne(message => message.SupportGroup)
                        .WithMany(group => group.Received)
                        .HasForeignKey(message => message.GroupId)
                        .OnDelete(DeleteBehavior.NoAction);


            //Create MessageChatapplicationUser Table
            modelBuilder.Entity<ChatApplicationUser>()
                        .HasMany(chatuser => chatuser.Received)
                        .WithMany(message => message.Receivers)
                        .UsingEntity<Dictionary<string, object>>(
                            "MessageChatapplicationUser",
                            j => j
                                .HasOne<Message>()
                                .WithMany()
                                .HasForeignKey("MessageId")
                                .OnDelete(DeleteBehavior.Cascade),
                            j => j
                                .HasOne<ChatApplicationUser>()
                                .WithMany()
                                .HasForeignKey("ChatUserId")
                                .OnDelete(DeleteBehavior.ClientCascade));

            //Create GuardianChild Table
            modelBuilder.Entity<GuardianApplicationUser>()
                        .HasMany(guardian => guardian.Children)
                        .WithMany(child => child.Guardians)
                        .UsingEntity<Dictionary<string, object>>(
                            "GuardianChild",
                            j => j
                                .HasOne<ClientApplicationUser>()
                                .WithMany()
                                .HasForeignKey("ChildId")
                                .OnDelete(DeleteBehavior.Cascade),
                            j => j
                                .HasOne<GuardianApplicationUser>()
                                .WithMany()
                                .HasForeignKey("GuardianId")
                                .OnDelete(DeleteBehavior.ClientCascade));

            //Create ChatApplicationSupportGroup Table
            modelBuilder.Entity<ChatApplicationUser>()
                        .HasMany(chatuser => chatuser.SupportGroups)
                        .WithMany(group => group.ChatApplicationUsers)
                        .UsingEntity<Dictionary<string, object>>(
                            "ChatApplicationUserSupportGroup",
                            j => j
                                .HasOne<SupportGroup>()
                                .WithMany()
                                .HasForeignKey("GroupId")
                                .OnDelete(DeleteBehavior.Cascade),
                            j => j
                                .HasOne<ChatApplicationUser>()
                                .WithMany()
                                .HasForeignKey("ChatUserId")
                                .OnDelete(DeleteBehavior.ClientCascade));

            //Seed Admins
            ApplicationUser angelo = new ApplicationUser()  
            {  
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

            ApplicationUser dechaun = new ApplicationUser()  
            {  
                FirstName = "Dechaun",
                LastName = "OkOk",
                UserName = "dechaun@okokapp.nl",  
                Email = "dechaun@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "dechaun@okokapp.nl".ToUpper(),
                NormalizedUserName = "dechaun@okokapp.nl".ToUpper()
            };

            ApplicationUser timothy = new ApplicationUser()  
            {   
                FirstName = "Timothy",
                LastName = "OkOk",
                UserName = "timothy@okokapp.nl",  
                Email = "timothy@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "timothy@okokapp.nl".ToUpper(),
                NormalizedUserName = "timothy@okokapp.nl".ToUpper()
            };

            //Seed Doctors
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

            DoctorApplicationUser doctorTwo = new DoctorApplicationUser()  
            {   
                FirstName = "Doctor",
                LastName = "Two",
                UserName = "doctortwo@okokapp.nl",  
                Email = "doctortwo@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                Specialism = "Autisme",
                NormalizedEmail = "doctortwo@okokapp.nl".ToUpper(),
                NormalizedUserName = "doctortwo@okokapp.nl".ToUpper()
            };

            //Seed Address
            Address addressOne = new Address()
            {
                Id = Guid.NewGuid(),
                Street = "Dorpsstraat",
                City = "Dorp",
                ZipCode = "1234AB",
                HouseNumber = 1,
                Country = "Nederland"
            };

            Address addressTwo = new Address()
            {
                Id = Guid.NewGuid(),
                Street = "Dorpsstraat",
                City = "Dorp",
                ZipCode = "1234AB",
                HouseNumber = 1,
                Country = "Nederland"
            };

            modelBuilder.Entity<Address>().HasData(addressOne, addressTwo);

            //Seed Clients
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
                AddressId = addressOne.Id,
                NormalizedEmail = "clientone@okokapp.nl".ToUpper(),
                NormalizedUserName = "clientone@okokapp.nl".ToUpper()
            };

            ClientApplicationUser clientTwo = new ClientApplicationUser()
            {
                FirstName = "Client",
                LastName = "Two",
                UserName = "clienttwo@okokapp.nl",  
                Email = "clienttwo@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                AddressId = addressTwo.Id,
                NormalizedEmail = "clienttwo@okokapp.nl".ToUpper(),
                NormalizedUserName = "clienttwo@okokapp.nl".ToUpper()
            };

            GuardianApplicationUser guardianOne = new GuardianApplicationUser()
            {
                FirstName = "Guardian",
                LastName = "One",
                UserName = "guardianone@okokapp.nl",  
                Email = "guardianone@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "guardianone@okokapp.nl".ToUpper(),
                NormalizedUserName = "guardianone@okokapp.nl".ToUpper()
            };

            GuardianApplicationUser guardianTwo = new GuardianApplicationUser()
            {
                FirstName = "Guardian",
                LastName = "Two",
                UserName = "guardiantwo@okokapp.nl",  
                Email = "guardiantwo@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "guardiantwo@okokapp.nl".ToUpper(),
                NormalizedUserName = "guardiantwo@okokapp.nl".ToUpper()
            };
  
            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();  
            angelo.PasswordHash = passwordHasher.HashPassword(angelo, "Admin123");
            dechaun.PasswordHash = passwordHasher.HashPassword(dechaun, "Admin123");  
            timothy.PasswordHash = passwordHasher.HashPassword(timothy, "Admin123");  
            doctorOne.PasswordHash = passwordHasher.HashPassword(doctorOne, "Doctor123");  
            doctorTwo.PasswordHash = passwordHasher.HashPassword(doctorTwo, "Doctor123");  
            guardianOne.PasswordHash = passwordHasher.HashPassword(guardianOne, "Guardian123");
            guardianTwo.PasswordHash = passwordHasher.HashPassword(guardianTwo, "Guardian123");
            clientOne.PasswordHash = passwordHasher.HashPassword(clientOne, "Client123");  
            clientTwo.PasswordHash = passwordHasher.HashPassword(clientTwo, "Client123");  

            modelBuilder.Entity<ApplicationUser>().HasData(angelo, dechaun, timothy);
            modelBuilder.Entity<ClientApplicationUser>().HasData(clientOne, clientTwo);
            modelBuilder.Entity<DoctorApplicationUser>().HasData(doctorOne, doctorTwo);
            modelBuilder.Entity<GuardianApplicationUser>().HasData(guardianOne, guardianTwo);

            var guardianChildOne = new { ChildId = clientOne.Id, GuardianId = guardianOne.Id};
            var guardianChildTwo = new { ChildId = clientTwo.Id, GuardianId = guardianTwo.Id};

            modelBuilder.Entity("GuardianChild").HasData(guardianChildOne, guardianChildTwo);

            string dateTimeNow = DateTime.Now.ToString("dd-MM-yyyy");
            CultureInfo provider = new CultureInfo("nl-NL");

            //Seed Treatments
                Treatment treatmentCDOne1 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorOne.Id,
                    ClientId = clientOne.Id,
                    DateTime = DateTime.Parse(dateTimeNow + " 10:30:00", provider),
                    Description = "Intake"
                };

                Treatment treatmentCDOne2 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorOne.Id,
                    ClientId = clientOne.Id,
                    DateTime = DateTime.Parse(dateTimeNow + " 11:00:00", provider),
                    Description = "Behandeling"
                };

                Treatment treatmentCDOne3 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorOne.Id,
                    ClientId = clientOne.Id,
                    DateTime = DateTime.Parse(dateTimeNow + " 11:30:00", provider),
                    Description = "Behandeling"
                };

                Treatment treatmentCDOne4 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorOne.Id,
                    ClientId = clientOne.Id,
                    DateTime = DateTime.Parse("11-01-2022 10:30:00", provider),
                    Description = "Intake"
                };

                Treatment treatmentCDOne5 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorOne.Id,
                    ClientId = clientOne.Id,
                    DateTime = DateTime.Parse("11-01-2022 11:00:00", provider),
                    Description = "Behandeling"
                };

                Treatment treatmentCDOne6 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorOne.Id,
                    ClientId = clientOne.Id,
                    DateTime = DateTime.Parse("11-01-2022 11:30:00", provider),
                    Description = "Behandeling"
                };

                Treatment treatmentCDOne7 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorOne.Id,
                    ClientId = clientOne.Id,
                    DateTime = DateTime.Parse("28-02-2022 10:30:00", provider),
                    Description = "Intake"
                };

                Treatment treatmentCDOne8 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorOne.Id,
                    ClientId = clientOne.Id,
                    DateTime = DateTime.Parse("28-02-2022 11:00:00", provider),
                    Description = "Behandeling"
                };

                Treatment treatmentCDOne9 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorOne.Id,
                    ClientId = clientOne.Id,
                    DateTime = DateTime.Parse("28-02-2022 11:30:00", provider),
                    Description = "Behandeling"
                };

                Treatment treatmentCDTwo1 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorTwo.Id,
                    ClientId = clientTwo.Id,
                    DateTime = DateTime.Parse(dateTimeNow + " 10:30:00", provider),
                    Description = "Intake"
                };

                Treatment treatmentCDTwo2 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorTwo.Id,
                    ClientId = clientTwo.Id,
                    DateTime = DateTime.Parse(dateTimeNow + " 11:00:00", provider),
                    Description = "Behandeling"
                };

                Treatment treatmentCDTwo3 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorTwo.Id,
                    ClientId = clientTwo.Id,
                    DateTime = DateTime.Parse(dateTimeNow + " 11:30:00", provider),
                    Description = "Behandeling"
                };

                Treatment treatmentCDTwo4 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorTwo.Id,
                    ClientId = clientTwo.Id,
                    DateTime = DateTime.Parse("11-01-2022 10:30:00", provider),
                    Description = "Intake"
                };

                Treatment treatmentCDTwo5 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorTwo.Id,
                    ClientId = clientTwo.Id,
                    DateTime = DateTime.Parse("11-01-2022 11:00:00", provider),
                    Description = "Behandeling"
                };

                Treatment treatmentCDTwo6 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorTwo.Id,
                    ClientId = clientTwo.Id,
                    DateTime = DateTime.Parse("11-01-2022 11:30:00", provider),
                    Description = "Behandeling"
                };

                Treatment treatmentCDTwo7 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorTwo.Id,
                    ClientId = clientTwo.Id,
                    DateTime = DateTime.Parse("28-02-2022 10:30:00", provider),
                    Description = "Intake"
                };

                Treatment treatmentCDTwo8 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorTwo.Id,
                    ClientId = clientTwo.Id,
                    DateTime = DateTime.Parse("28-02-2022 11:00:00", provider),
                    Description = "Behandeling"
                };

                Treatment treatmentCDTwo9 = new Treatment()
                {
                    Id = Guid.NewGuid(),
                    DoctorId = doctorTwo.Id,
                    ClientId = clientTwo.Id,
                    DateTime = DateTime.Parse("28-02-2022 11:30:00", provider),
                    Description = "Behandeling"
                };

            modelBuilder.Entity<Treatment>().HasData(treatmentCDOne1,treatmentCDOne2,treatmentCDOne3,treatmentCDOne4,treatmentCDOne5,treatmentCDOne6,treatmentCDOne7,treatmentCDOne8,treatmentCDOne9,treatmentCDTwo1,treatmentCDTwo2,treatmentCDTwo3,treatmentCDTwo4,treatmentCDTwo5,treatmentCDTwo6,treatmentCDTwo7,treatmentCDTwo8,treatmentCDTwo9);

            //Messages
            Message messageOne = new Message()
            {
                Id = Guid.NewGuid(),
                Content = "Dit is een geseede message [1]",
                DateTime = DateTime.Now,
                SenderId = clientOne.Id
            };

            Message messageTwo = new Message()
            {
                Id = Guid.NewGuid(),
                Content = "Dit is een geseede message [2]",
                DateTime = DateTime.Now,
                SenderId = clientOne.Id
            };

            Message messageThree = new Message()
            {
                Id = Guid.NewGuid(),
                Content = "Dit is een geseede message [3]",
                DateTime = DateTime.Now,
                SenderId = clientTwo.Id
            };

            Message messageFour = new Message()
            {
                Id = Guid.NewGuid(),
                Content = "Dit is een geseede message [4]",
                DateTime = DateTime.Now,
                SenderId = clientTwo.Id
            };

            modelBuilder.Entity<Message>().HasData(messageOne, messageTwo, messageThree, messageFour);

            //Reports
            Report reportOne = new Report()
            {
                Id = Guid.NewGuid(),
                Handled = false
            };

            Report reportTwo = new Report()
            {
                Id = Guid.NewGuid(),
                Handled = false
            };

            Report reportThree = new Report()
            {
                Id = Guid.NewGuid(),
                Handled = false
            };

            Report reportFour = new Report()
            {
                Id = Guid.NewGuid(),
                Handled = false
            };

            modelBuilder.Entity<Report>().HasData(reportOne, reportTwo, reportThree, reportFour);

            //MessageReports
            MessageReport mrOne = new MessageReport()
            {
                MessageId = messageOne.Id,
                ReportId = reportOne.Id
            };

            MessageReport mrTwo = new MessageReport()
            {
                MessageId = messageOne.Id,
                ReportId = reportTwo.Id
            };

            MessageReport mrThree = new MessageReport()
            {
                MessageId = messageOne.Id,
                ReportId = reportThree.Id
            };

            MessageReport mrFour = new MessageReport()
            {
                MessageId = messageThree.Id,
                ReportId = reportFour.Id
            };

            modelBuilder.Entity<MessageReport>().HasData(mrOne, mrTwo, mrThree, mrFour);

            //SignUpRequests
            SignUpRequest surOne = new SignUpRequest()
            {
                Id = Guid.NewGuid(),
                Handled = false,
                DoctorId = doctorOne.Id,
                ClientId = clientOne.Id
            };

            SignUpRequest surTwo = new SignUpRequest()
            {
                Id = Guid.NewGuid(),
                Handled = false,
                DoctorId = doctorOne.Id,
                ClientId = clientTwo.Id
            };

            modelBuilder.Entity<SignUpRequest>().HasData(surOne, surTwo);

            //SeedRoles
            IdentityRole admin = new IdentityRole()
            {
                Name = "Admin", 
                ConcurrencyStamp = "1", 
                NormalizedName = "Admin".ToUpper() 
            };

            IdentityRole doctor = new IdentityRole()
            {
                Name = "Doctor", 
                ConcurrencyStamp = "1", 
                NormalizedName = "Doctor".ToUpper() 
            };

            IdentityRole client = new IdentityRole()
            {
                Name = "Client", 
                ConcurrencyStamp = "1", 
                NormalizedName = "Client".ToUpper() 
            };

            IdentityRole guardian = new IdentityRole()
            {
                Name = "Guardian", 
                ConcurrencyStamp = "1", 
                NormalizedName = "Guardian".ToUpper() 
            };

            modelBuilder.Entity<IdentityRole>().HasData(admin, doctor, client, guardian);  

            //SeedUserRoles
            IdentityUserRole<string> angeloAdmin = new IdentityUserRole<string>()
            {
                RoleId = admin.Id,
                UserId = angelo.Id
            };

            IdentityUserRole<string> dechaunAdmin = new IdentityUserRole<string>()
            {
                RoleId = admin.Id,
                UserId = dechaun.Id
            };

            IdentityUserRole<string> timothyAdmin = new IdentityUserRole<string>()
            {
                RoleId = admin.Id,
                UserId = timothy.Id
            };

            IdentityUserRole<string> doctorOneDoctor = new IdentityUserRole<string>()
            {
                RoleId = doctor.Id,
                UserId = doctorOne.Id
            };

            IdentityUserRole<string> doctorTwoDoctor = new IdentityUserRole<string>()
            {
                RoleId = doctor.Id,
                UserId = doctorTwo.Id
            };

            IdentityUserRole<string> clientOneClient = new IdentityUserRole<string>()
            {
                RoleId = client.Id,
                UserId = clientOne.Id
            };

            IdentityUserRole<string> clientTwoClient = new IdentityUserRole<string>()
            {
                RoleId = client.Id,
                UserId = clientTwo.Id
            };

            IdentityUserRole<string> guardianOneGuardian = new IdentityUserRole<string>()
            {
                RoleId = guardian.Id,
                UserId = guardianOne.Id
            };

            IdentityUserRole<string> guardianTwoGuardian = new IdentityUserRole<string>()
            {
                RoleId = guardian.Id,
                UserId = guardianTwo.Id
            };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(angeloAdmin, dechaunAdmin, timothyAdmin);  
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(doctorOneDoctor, doctorTwoDoctor);  
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(clientOneClient, clientTwoClient);  
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(guardianOneGuardian, guardianTwoGuardian);  
        }
    }
}