using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCase.Tasks.GetAll;

public class GetAllTaskUseCase
{
    public ResponseAllTaskJson Execute()
    {
        return new ResponseAllTaskJson()
        {
            Task = new List<ResponseShortTaskJson>
            {
                new ResponseShortTaskJson
                {
                    Priority = Communication.Enums.TaskPriority.Low,
                    Id = 1,
                    Name = "Test",
                    Status = Communication.Enums.TaskStatus.InProgress
                }
            }
        };
    }
}
