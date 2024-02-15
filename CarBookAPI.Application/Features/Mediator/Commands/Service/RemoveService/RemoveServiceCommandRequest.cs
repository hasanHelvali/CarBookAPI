using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Service.RemoveService
{
    public class RemoveServiceCommandRequest:IRequest
    {
        public int ID { get; set; }

        public RemoveServiceCommandRequest(int id)
        {
            ID = id;
        }
    }
}