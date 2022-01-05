using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using OkOk.Models;
using OkOk.Models.Identity;

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
        
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);  

            

            //Relations

            //Treatment
            modelBuilder.Entity<Treatment>()
                        .HasOne(treatment => treatment.ClientApplicationUser)
                        .WithMany(client => client.Treatments)
                        .HasForeignKey(treatment => treatment.ClientId)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Treatment>()
                        .HasOne(treatment => treatment.DoctorApplicationUser)
                        .WithMany(doctor => doctor.Treatments)
                        .HasForeignKey(treatment => treatment.DoctorId)
                        .OnDelete(DeleteBehavior.SetNull);

            //MessageReport
            modelBuilder.Entity<MessageReport>()
                        .HasKey(composite => new { composite.MessageId, composite.ReportId});

            modelBuilder.Entity<MessageReport>()
                        .HasOne(mreport => mreport.Message)
                        .WithMany(message => message.MessageReports)
                        .HasForeignKey(mreport => mreport.MessageId)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<MessageReport>()
                        .HasOne(mreport => mreport.Report)
                        .WithOne(report => report.MessageReport)
                        .HasForeignKey<MessageReport>(mreport => mreport.ReportId)
                        .OnDelete(DeleteBehavior.SetNull);

            //SignUpRequest
            modelBuilder.Entity<ClientApplicationUser>()
                        .HasOne(client => client.SignUpRequest)
                        .WithOne(signup => signup.ClientApplicationUser)
                        .HasForeignKey<SignUpRequest>(signup => signup.ClientId)
                        .IsRequired()
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<SignUpRequest>()
                        .HasOne(signup => signup.DoctorApplicationUser)
                        .WithMany(doctor => doctor.SignUpRequests)
                        .HasForeignKey(signup => signup.DoctorId)
                        .OnDelete(DeleteBehavior.SetNull);

            //Message
            modelBuilder.Entity<Message>()
                        .HasOne(message => message.ChatApplicationUser)
                        .WithMany(chatuser => chatuser.Messages)
                        .HasForeignKey(message => message.ChatUserId)
                        .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Message>()
                        .HasOne(message => message.SupportGroup)
                        .WithMany(group => group.Messages)
                        .HasForeignKey(message => message.GroupId)
                        .OnDelete(DeleteBehavior.SetNull);

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

            //SeedUsers
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

            ApplicationUser yash = new ApplicationUser()  
            {   
                FirstName = "Yash",
                LastName = "OkOk",
                UserName = "yash@okokapp.nl",  
                Email = "yash@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "yash@okokapp.nl".ToUpper(),
                NormalizedUserName = "yash@okokapp.nl".ToUpper()
            };


  
            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();  
            angelo.PasswordHash = passwordHasher.HashPassword(angelo, "Admin123");
            dechaun.PasswordHash = passwordHasher.HashPassword(dechaun, "Admin123");  
            timothy.PasswordHash = passwordHasher.HashPassword(timothy, "Admin123");  
            yash.PasswordHash = passwordHasher.HashPassword(yash, "Admin123");  
  
            modelBuilder.Entity<ApplicationUser>().HasData(angelo);
            modelBuilder.Entity<ApplicationUser>().HasData(dechaun);
            modelBuilder.Entity<ApplicationUser>().HasData(timothy);
            modelBuilder.Entity<ApplicationUser>().HasData(yash);

            //SeedRoles
            IdentityRole admin = new IdentityRole()
            {
                Name = "Admin", 
                ConcurrencyStamp = "1", 
                NormalizedName = "Admin".ToUpper() 
            };

            modelBuilder.Entity<IdentityRole>().HasData(admin);  

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

            IdentityUserRole<string> yashAdmin = new IdentityUserRole<string>()
            {
                RoleId = admin.Id,
                UserId = yash.Id
            };


            modelBuilder.Entity<IdentityUserRole<string>>().HasData(angeloAdmin);  
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(dechaunAdmin);  
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(timothyAdmin);  
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(yashAdmin);  
        }
    }
}