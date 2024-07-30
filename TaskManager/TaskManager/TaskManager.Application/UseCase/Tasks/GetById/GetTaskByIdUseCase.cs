using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCase.Tasks.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson
        {
            Id = id,
            Name = "Test",
            Description = "Test",
            Priority = Communication.Enums.TaskPriority.High,
            Status = Communication.Enums.TaskStatus.Completed,
            Type = Communication.Enums.TaskType.ConfigureDataBase,
            Deadline = new DateTime(year: 2024, month: 10, day: 12)
        };
    }
}
