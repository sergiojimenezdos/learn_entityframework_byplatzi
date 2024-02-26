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
        modelBuilder.Entity<Category>(category =>
        {
            category.ToTable("Category");
            category.HasKey(k => k.CategoryId);
            category.Property(p => p.Name).IsRequired().HasMaxLength(150);
            category.Property(p => p.Description);
        });

        modelBuilder.Entity<Models.Task>(t =>
        {
            t.ToTable("Task");
            t.HasKey(p => p.TaskId);
            t.HasOne(p => p.Category).WithMany(p => p.Tasks).HasForeignKey(p => p.CategoryId);
            t.Property(p => p.Title).IsRequired().HasMaxLength(200);
            t.Property(p => p.Description);
            t.Property(p => p.Priority);
            t.Property(p => p.CreationDate);
            t.Ignore(p => p.Summary);
        });
    }
}