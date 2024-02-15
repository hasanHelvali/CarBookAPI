using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Location.RemoveLocation
{
    public class RemoveLocationCommandRequest:IRequest
    {
        public int ID { get; set; }

        public RemoveLocationCommandRequest(int id)
        {
            ID = id;
        }
    }
}