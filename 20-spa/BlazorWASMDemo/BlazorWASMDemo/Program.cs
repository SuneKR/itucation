using BlazorWASMDemo.Client.Pages;
using BlazorWASMDemo.Components;
using BlazorWASMDemo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

// Add controller for api
builder.Services.AddControllers();

// Add dbContext
builder.Services.AddDbContext<KundeDB>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("KundeDB")));
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5203") });

// Add a scoped service for http calls
var baseAddress = builder.Configuration.GetValue<string>("BaseUrl");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();

// Map controller for API - needs to happen before UseAntiforgery()
app.MapControllers();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorWASMDemo.Client._Imports).Assembly);

app.Run();
