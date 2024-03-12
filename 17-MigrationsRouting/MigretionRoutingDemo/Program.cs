using Microsoft.EntityFrameworkCore;
using MigretionRoutingDemo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<SalesDB>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("SalesDB")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Customers}/{action=Index}/{id?}");

//Conventional routing
//app.MapControllerRoute(
//    name: "FindCustomerByName",
//    pattern: "Find/{navn}",
//    defaults: new { controller = "Customers", action = "DetailsByName" });

app.Run();
