using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCase.Tasks.Register;

public class RegisterTaskUseCase
{
    public ResponseRegisterTaskJson Execute(RequestTaskJson request)
    {
        return new ResponseRegisterTaskJson
        {
            Id = 1,
            Name = request.Name
        };
    }
}
