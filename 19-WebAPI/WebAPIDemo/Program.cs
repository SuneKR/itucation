using Microsoft.EntityFrameworkCore;
using WebAPIDemo.ExternalCall;
using WebAPIDemo.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddSingleton<IBooksInterface, BooksRepository>();

builder.Services.AddDbContext<BooksDB>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("BooksDB")));
builder.Services.AddScoped<IBooksInterface, BooksDatabaseRepository>();

builder.Services.AddHttpClient<IExternalData, ExternalClient>();

//Singleton en unik instats af servicen
//Scoped betyder alle http request opretter nye service (bruger ny samme service hele vejen igennem hele requesten)
//transcient ny instats for hver gang servicen skal bruges (Flere end scoped)

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
