using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using OkOk.Models;
using OkOk.Services;

namespace OkOk.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public DbSet<ClientApplicationUser> ClientApplicationUsers { get; set; }
        public DbSet<DoctorApplicationUser> DoctorApplicationUsers { get; set; }
        
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);  

            //SeedUsers
            IdentityUser angelo = new IdentityUser()  
            {  
                UserName = "angelo@okokapp.nl",  
                Email = "angelo@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "angelo@okokapp.nl".ToUpper(),
                NormalizedUserName = "angelo@okokapp.nl".ToUpper()
            };

            IdentityUser dechaun = new IdentityUser()  
            {  
                UserName = "dechaun@okokapp.nl",  
                Email = "dechaun@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "dechaun@okokapp.nl".ToUpper(),
                NormalizedUserName = "dechaun@okokapp.nl".ToUpper()
            };

            IdentityUser timothy = new IdentityUser()  
            {   
                UserName = "timothy@okokapp.nl",  
                Email = "timothy@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "timothy@okokapp.nl".ToUpper(),
                NormalizedUserName = "timothy@okokapp.nl".ToUpper()
            };

            IdentityUser yash = new IdentityUser()  
            {   
                UserName = "yash@okokapp.nl",  
                Email = "yash@okokapp.nl",  
                LockoutEnabled = false,  
                PhoneNumber = "1234567890",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                NormalizedEmail = "yash@okokapp.nl".ToUpper(),
                NormalizedUserName = "yash@okokapp.nl".ToUpper()
            };


  
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();  
            angelo.PasswordHash = passwordHasher.HashPassword(angelo, "Admin123");
            dechaun.PasswordHash = passwordHasher.HashPassword(dechaun, "Admin123");  
            timothy.PasswordHash = passwordHasher.HashPassword(timothy, "Admin123");  
            yash.PasswordHash = passwordHasher.HashPassword(yash, "Admin123");  
  
            modelBuilder.Entity<IdentityUser>().HasData(angelo);
            modelBuilder.Entity<IdentityUser>().HasData(dechaun);
            modelBuilder.Entity<IdentityUser>().HasData(timothy);
            modelBuilder.Entity<IdentityUser>().HasData(yash);

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