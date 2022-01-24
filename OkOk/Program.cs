using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using OkOk.Hubs;
using OkOk.Data;
using OkOk.Models.Identity;
using OkOk.Controllers;
using Microsoft.AspNetCore.SignalR;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionApplicationDbContext")));
}
else
{
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionApplicationDbContext")));
}

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddIdentityCore<ChatApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddIdentityCore<ClientApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddTokenProvider<DataProtectorTokenProvider<ClientApplicationUser>>(TokenOptions.DefaultProvider);

builder.Services.AddScoped<SignInManager<ClientApplicationUser>, SignInManager<ClientApplicationUser>>();
builder.Services.AddScoped<UserManager<ClientApplicationUser>, UserManager<ClientApplicationUser>>();
builder.Services.AddScoped<SignUpRequestController, SignUpRequestController>();

builder.Services.AddIdentityCore<DoctorApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddTokenProvider<DataProtectorTokenProvider<DoctorApplicationUser>>(TokenOptions.DefaultProvider);

builder.Services.AddScoped<SignInManager<DoctorApplicationUser>, SignInManager<DoctorApplicationUser>>();
builder.Services.AddScoped<UserManager<DoctorApplicationUser>, UserManager<DoctorApplicationUser>>();

builder.Services.AddIdentityCore<GuardianApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddTokenProvider<DataProtectorTokenProvider<GuardianApplicationUser>>(TokenOptions.DefaultProvider);

builder.Services.AddScoped<SignInManager<GuardianApplicationUser>, SignInManager<GuardianApplicationUser>>();
builder.Services.AddScoped<UserManager<GuardianApplicationUser>, UserManager<GuardianApplicationUser>>();

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
