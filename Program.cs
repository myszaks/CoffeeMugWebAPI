using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CoffeeMugWebAPI.Data;
using CoffeeMugWebAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CoffeeMugWebAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CoffeeMugWebAPIContext")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
