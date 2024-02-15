using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Service.UpdateService
{
    public class UpdateServiceCommandRequest:IRequest
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}