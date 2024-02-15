using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Location.CreateLocation
{
    public class CreateLocationCommandRequest:IRequest
    {
        public string Name { get; set; }

    }
}