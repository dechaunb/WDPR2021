using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using OkOk.Hubs;
using OkOk.Data;
using OkOk.Models.Identity;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("DevelopmentApplicationDbContext")));
}
else
{
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionApplicationDbContext")));
}

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddIdentityCore<ChatApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddIdentityCore<ClientApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddIdentityCore<DoctorApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddTokenProvider<DataProtectorTokenProvider<DoctorApplicationUser>>(TokenOptions.DefaultProvider);

builder.Services.AddScoped<SignInManager<DoctorApplicationUser>, SignInManager<DoctorApplicationUser>>();
builder.Services.AddScoped<UserManager<DoctorApplicationUser>, UserManager<DoctorApplicationUser>>();

builder.Services.AddIdentityCore<GuardianApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();


//Identity Services
// builder.Services.AddScoped<IUserValidator<DoctorApplicationUser>, UserValidator<DoctorApplicationUser>>();
// builder.Services.AddScoped<IPasswordValidator<DoctorApplicationUser>, PasswordValidator<DoctorApplicationUser>>();
// builder.Services.AddScoped<IPasswordHasher<DoctorApplicationUser>, PasswordHasher<DoctorApplicationUser>>();
// builder.Services.AddScoped<ILookupNormalizer, UpperInvariantLookupNormalizer>();
// builder.Services.AddScoped<IRoleValidator<IdentityRole>, RoleValidator<IdentityRole>>();
// // No interface for the error describer so we can add errors without rev'ing the interface
// builder.Services.AddScoped<IdentityErrorDescriber>();
// builder.Services.AddScoped<ISecurityStampValidator, SecurityStampValidator<DoctorApplicationUser>>();
// builder.Services.AddScoped<ITwoFactorSecurityStampValidator, TwoFactorSecurityStampValidator<DoctorApplicationUser>>();
// builder.Services.AddScoped<IUserClaimsPrincipalFactory<DoctorApplicationUser>, UserClaimsPrincipalFactory<DoctorApplicationUser, IdentityRole>>();
// builder.Services.AddScoped<UserManager<DoctorApplicationUser>>();
// builder.Services.AddScoped<SignInManager<DoctorApplicationUser>>();
// builder.Services.AddScoped<RoleManager<IdentityRole>>();

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();
builder.Services.AddSingleton<IUserIdProvider, CustomUserIdProvider>();
builder.Services.AddSignalR();


var app = builder.Build();
app.MapHub<ChatHub>("/chatHub");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
