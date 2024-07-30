using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;

public class ResponseTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public TaskType Type { get; set; }
    public TaskPriority Priority { get; set; }
    public Enums.TaskStatus Status { get; set; }
    public string Description { get; set; } = string.Empty;
    public DateTime Deadline { get; set; }
}
