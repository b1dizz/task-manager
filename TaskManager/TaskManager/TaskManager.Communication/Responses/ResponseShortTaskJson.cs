using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;

public class ResponseShortTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public Enums.TaskStatus Status { get; set; }

}
