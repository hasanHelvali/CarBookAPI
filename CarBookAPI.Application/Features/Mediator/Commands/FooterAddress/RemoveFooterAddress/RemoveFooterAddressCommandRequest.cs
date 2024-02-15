using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.FooterAddress.RemoveFooterAddress
{
    public class RemoveFooterAddressCommandRequest:IRequest
    {
        public int ID { get; set; }

        public RemoveFooterAddressCommandRequest(int id)
        {
            ID = id;
        }
    }
}