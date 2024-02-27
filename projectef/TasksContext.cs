using Microsoft.EntityFrameworkCore;
using projectef.Models;

namespace projectef;

public class TasksContext: DbContext
{
    public DbSet<Category> Categories {get;set;}
    public DbSet<Models.Task> Tasks{get;set;}
    public TasksContext(DbContextOptions<TasksContext> options): base(options){}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        CreateCategoryTable(modelBuilder);
        CreateTaskTable(modelBuilder);
    }

    private static void CreateCategoryTable(ModelBuilder modelBuilder)
    {
        List<Category> categories = new List<Category>();
        categories.Add(new Category
        {
            CategoryId = Guid.Parse("fbc0708d-e650-4f8b-9be4-da4d57496276"),
            Name = "Pending tasks",
            Priotity = 2
        });
        categories.Add(new Category
        {
            CategoryId = Guid.Parse("f54b9320-807c-4c3d-867c-b98522e2c6ac"),
            Name = "Personal tasks",
            Priotity = 5
        });
        modelBuilder.Entity<Category>(category =>
        {
            category.ToTable("Category");
            category.HasKey(k => k.CategoryId);
            category.Property(p => p.Name).IsRequired().HasMaxLength(150);
            category.Property(p => p.Description).IsRequired(false);
            category.Property(p => p.Priotity);

            category.HasData(categories);
        });
    }

    private static void CreateTaskTable(ModelBuilder modelBuilder)
    {
        List<Models.Task> tasks = new List<Models.Task>();
        tasks.Add(new Models.Task
        {
            TaskId = Guid.Parse("fbc0708d-e650-4f8b-9be4-da4d57496295"),
            CategoryId = Guid.Parse("fbc0708d-e650-4f8b-9be4-da4d57496276"),
            Priority = Priority.Medium,
            Title = "Payment of public services",
            CreationDate = DateTime.Now
        });
        tasks.Add(new Models.Task
        {
            TaskId = Guid.Parse("fbc0708d-e650-4f8b-9be4-da4d57496296"),
            CategoryId = Guid.Parse("f54b9320-807c-4c3d-867c-b98522e2c6ac"),
            Priority = Priority.Low,
            Title = "Netflix movie",
            CreationDate = DateTime.Now
        });


        modelBuilder.Entity<Models.Task>(t =>
        {
            t.ToTable("Task");
            t.HasKey(p => p.TaskId);
            t.HasOne(p => p.Category).WithMany(p => p.Tasks).HasForeignKey(p => p.CategoryId);
            t.Property(p => p.Title).IsRequired().HasMaxLength(200);
            t.Property(p => p.Description).IsRequired(false);
            t.Property(p => p.Priority);
            t.Property(p => p.CreationDate);
            t.Ignore(p => p.Summary);

            t.HasData(tasks);
        });
    }
}