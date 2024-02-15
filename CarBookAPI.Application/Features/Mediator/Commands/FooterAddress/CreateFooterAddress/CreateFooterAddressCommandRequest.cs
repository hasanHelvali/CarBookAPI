using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.FooterAddress.CreateFooterAddress
{
    public class CreateFooterAddressCommandRequest:IRequest
    {
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}