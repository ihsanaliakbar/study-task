namespace StudyTasks.Api.Model;
public class TaskItem
{
    public int Id { get; set; }
    public int ProjectId { get; set; } //FK to Project
    public string Title { get; set; }
    public string? Description { get; set; }
    public string Status { get; set; } = "Open";
    public DateTime? DueDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public Project? Project { get; set; }
}