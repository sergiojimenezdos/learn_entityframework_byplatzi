using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projectef;

var builder = WebApplication.CreateBuilder(args);

// Set connection to Database in Memory
//builder.Services.AddDbContext<TasksContext>(p => p.UseInMemoryDatabase("TasksDB"));

// Set connection to SQL Server
builder.Services.AddSqlServer<TasksContext>(builder.Configuration.GetConnectionString("LocalSqlServer"));


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconnection", async([FromServices] TasksContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Database in memory: " + dbContext.Database.IsInMemory());
});

app.MapGet("/api/tasks", async ([FromServices] TasksContext dbContext) =>
{
    return Results.Ok(dbContext.Tasks);
});

app.MapGet("/api/lowertasks", async ([FromServices] TasksContext dbContext) =>
{
    return Results.Ok(dbContext.Tasks.Where(t => t.Priority == projectef.Models.Priority.Low));
});


app.MapGet("/api/lowertasksfull", async ([FromServices] TasksContext dbContext) =>
{
    return Results.Ok(dbContext.Tasks.Include(t=>t.Category).Where(t => t.Priority == projectef.Models.Priority.Low));
});


app.MapPost("/api/inserttask", async ([FromServices] TasksContext dbContext, [FromBody] projectef.Models.Task myNewTask) =>
{
    myNewTask.TaskId = Guid.NewGuid();
    myNewTask.CreationDate = DateTime.Now;

    await dbContext.Tasks.AddAsync(myNewTask);
    await dbContext.SaveChangesAsync();

    return Results.Ok(myNewTask);
});

app.MapPut("/api/updatetask/{id}", async ([FromServices] TasksContext dbContext, [FromBody] projectef.Models.Task myTask, [FromRoute] Guid id) =>
{
    var task = await dbContext.Tasks.FindAsync(id);
    if (task == null)
    {
        return Results.NotFound();
    }

    task.Title = myTask.Title;
    task.Description = myTask.Description;
    task.Priority = myTask.Priority;
    task.Summary = myTask.Summary;
    task.CategoryId = myTask.CategoryId;
    await dbContext.SaveChangesAsync();

    return Results.Ok(task);
});

app.Run();
