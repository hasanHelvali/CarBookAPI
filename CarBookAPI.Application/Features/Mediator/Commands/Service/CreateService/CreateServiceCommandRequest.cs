using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Service.CreateService
{
    public class CreateServiceCommandRequest:IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}