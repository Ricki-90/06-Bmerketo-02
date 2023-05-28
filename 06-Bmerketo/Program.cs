using _06_Bmerketo.Accounts.Helpers.Repositories;
using _06_Bmerketo.Accounts.Helpers.Services;
using _06_Bmerketo.Accounts.Models.Identity;
using _06_Bmerketo.Constructs.Helpers.Repositories;
using _06_Bmerketo.Constructs.Helpers.Services;
using _06_Bmerketo.Database;
using _06_Bmerketo.Databases;
using _06_Bmerketo.Items.Helpers.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


//Contexts Database
builder.Services.AddDbContext<AccountsDB>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("AccountsDB")));
builder.Services.AddDbContext<ItemsDB>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("ItemsDB")));


// auth
builder.Services.AddIdentity<AppUser, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
    x.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<AccountsDB>();
builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/SignInView";
});


//Repo
builder.Services.AddScoped<AddressRepository>();
builder.Services.AddScoped<ContactFormRepository>();
builder.Services.AddScoped<ItemRepository>();
builder.Services.AddScoped<ItemTagRepository>();
builder.Services.AddScoped<TagRepository>();
builder.Services.AddScoped<UserAddressRepository>();

// service
builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<AddressService>();
builder.Services.AddScoped<UserAdminService>();



var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=HomeView}/{action=Index}/{id?}");

app.Run();