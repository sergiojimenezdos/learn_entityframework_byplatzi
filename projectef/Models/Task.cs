namespace projectef.Models;

public class Task
{
    public Guid TaskId {get; set;}
    public Guid CategoryId {get; set;}
    public string Title {get; set;}     
    public string Description {get; set;}     
    public Priority Priority {get; set;}     
    public DateTime CreationDate {get; set;}     
    public virtual Category Category{get; set;}    
    public string Summary{get;set;}
}

public enum Priority
{
    Low,
    Medium,
    High
}