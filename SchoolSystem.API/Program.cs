using Microsoft.EntityFrameworkCore;
using SchoolSystem.Infrastructure.Data;
using SchoolSystem.Infrastructure;
using SchoolSystem.Service;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Connection to SQL Server
builder.Services.AddDbContext<SchoolSystemDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("Dev"));
});

// Injecting Dependencies
builder.Services.InjectingInfrastructureDependencies();
builder.Services.InjectingServiceDependencies();
builder.Services.InjectingCoreDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
