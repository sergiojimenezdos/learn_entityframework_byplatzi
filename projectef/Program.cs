using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectef;

var builder = WebApplication.CreateBuilder(args);

// Set connection to Database in Memory
//builder.Services.AddDbContext<TasksContext>(p => p.UseInMemoryDatabase("TasksDB"));

// Set connection to SQL Server
builder.Services.AddSqlServer<TasksContext>("Data Source=(local); Initial Catalog= TasksDB;Trusted_Connection=True; Integrated Security=True;TrustServerCertificate=True");


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconnection", async([FromServices] TasksContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Database in memory: " + dbContext.Database.IsInMemory());
});

app.Run();
