using FluentValidation;
using Microsoft.EntityFrameworkCore;
using WebApplicationTest1;
using WebApplicationTest1.CQRS.Commands;
using WebApplicationTest1.repository;
using WebApplicationTest1.repository.repoImpl;
using WebApplicationTest1.service;
using WebApplicationTest1.service.impl;
using WebApplicationTest1.validator;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// registering validators
//builder.Services.AddScoped<EmployeeValidator>();


// registering repos
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

// registering services
//builder.Services.AddScoped<IDepartmentService, DepartmentService>();
//builder.Services.AddScoped<IEmployeeService, EmployeeService>();

// registering MediatR
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateDepartmentHandler).Assembly));


// registering validators
builder.Services.AddScoped<IValidator<CreateDepartmentCommand>, CreateDepartmentValidator>();


builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
