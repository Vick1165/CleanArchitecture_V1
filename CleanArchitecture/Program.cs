using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Logger;
using CleanArchitecture.Application.Manager;
using CleanArchitecture.Application.Mapper;
using CleanArchitecture.Core.Repositories;
using CleanArchitecture.Core.Repositories.Base;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Repositories;
using CleanArchitecture.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using NLog;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<EmployeeContext>(options => options.UseSqlServer(connectionString));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//register service
builder.Services.AddSingleton<ILoggerManager, LoggerManager>();
builder.Services.AddTransient<IEmployeeManager, EmployeeManager>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();

//Add Auto mapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddControllers();

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