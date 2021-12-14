// using Microsoft.AspNetCore.Identity;

// namespace OkOk.Data
// {
//     public class ContextSeed
//     {
//         public static async Task SeedAdminUsers(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
//         {
//             IdentityUser angelo = new IdentityUser()  
//             {  
//                 UserName = "angelo",  
//                 Email = "angelo@okokapp.nl",  
//                 LockoutEnabled = false,  
//                 PhoneNumber = "1234567890",
//                 EmailConfirmed = true,
//                 PhoneNumberConfirmed = true
//             };

//             IdentityUser dechaun = new IdentityUser()  
//             {  
//                 UserName = "dechaun",  
//                 Email = "dechaun@okokapp.nl",  
//                 LockoutEnabled = false,  
//                 PhoneNumber = "1234567890",
//                 EmailConfirmed = true,
//                 PhoneNumberConfirmed = true
//             };

//             IdentityUser timothy = new IdentityUser()  
//             {    
//                 UserName = "timothy",  
//                 Email = "timothy@okokapp.nl",  
//                 LockoutEnabled = false,  
//                 PhoneNumber = "1234567890",
//                 EmailConfirmed = true,
//                 PhoneNumberConfirmed = true
//             };

//             IdentityUser yash = new IdentityUser()  
//             {   
//                 UserName = "yash",  
//                 Email = "yash@okokapp.nl",  
//                 LockoutEnabled = false,  
//                 PhoneNumber = "1234567890",
//                 EmailConfirmed = true,
//                 PhoneNumberConfirmed = true
//             };

//             //INIT ADMIN
//             IdentityRole admin = new IdentityRole()
//             {
//                 Name = "Admin", 
//                 ConcurrencyStamp = "1", 
//                 NormalizedName = "Admin".ToUpper() 
//             };

//             await roleManager.CreateAsync(admin);
//             //INIT ANGELO
//             if (userManager.Users.All(u => u.Id != angelo.Id))
//             {
//                 var user = await userManager.FindByEmailAsync(angelo.Email);

//                 if(user==null)
//                 {
//                     await userManager.CreateAsync(angelo, "123Pa$$word.");
//                     await userManager.AddToRoleAsync(angelo, admin.Name);
//                 }
//             }
//             //INIT DECHAUN
//             if (userManager.Users.All(u => u.Id != dechaun.Id))
//             {
//                 var user = await userManager.FindByEmailAsync(dechaun.Email);

//                 if(user==null)
//                 {
//                     await userManager.CreateAsync(dechaun, "123Pa$$word.");
//                     await userManager.AddToRoleAsync(dechaun, admin.Name);
//                 }
//             }
//             //INIT TIMOTHY
//             if (userManager.Users.All(u => u.Id != timothy.Id))
//             {
//                 var user = await userManager.FindByEmailAsync(timothy.Email);

//                 if(user==null)
//                 {
//                     await userManager.CreateAsync(timothy, "123Pa$$word.");
//                     await userManager.AddToRoleAsync(timothy, admin.Name);
//                 }
//             }
//             //INIT YASH
//             if (userManager.Users.All(u => u.Id != yash.Id))
//             {
//                 var user = await userManager.FindByEmailAsync(yash.Email);

//                 if(user==null)
//                 {
//                     await userManager.CreateAsync(yash, "123Pa$$word.");
//                     await userManager.AddToRoleAsync(yash, admin.Name);
//                 }
//             }
//         }
//     }
// }