using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.EntityFrameworkCore;
using TaskWithYou.Server;
using TaskWithYou.Server.Data;
using TaskWithYou.Server.Models;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["AuthDBConnection"];
builder.Services.AddDbContext<AuthDBContext>(options =>
    options.UseNpgsql(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<AuthDBContext>();

builder.Services.AddIdentityServer()
    .AddApiAuthorization<ApplicationUser, AuthDBContext>();

builder.Services.AddAuthentication()
    .AddIdentityServerJwt()
    .AddGoogle(options =>
    {
        options.ClientId = builder.Configuration["ClientId"];
        options.ClientSecret = builder.Configuration["ClientSecret"];
        options.CallbackPath = "/singin-google";
    });

var appconnectionString = builder.Configuration["ApplicationDBConnection"];
builder.Services.AddDbContext<TaskWithYouAppDbContext>(options =>
    options.UseNpgsql(appconnectionString)
);

//SetupDB.GenerateDemoData(appconnectionString);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseIdentityServer();
app.UseAuthentication();
app.UseAuthorization();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
