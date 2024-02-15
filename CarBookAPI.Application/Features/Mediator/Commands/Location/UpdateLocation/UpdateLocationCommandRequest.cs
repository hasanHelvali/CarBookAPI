using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Location.UpdateLocation
{
    public class UpdateLocationCommandRequest:IRequest
    {
        public int LocationID { get; set; }
        public string Name { get; set; }
    }
}