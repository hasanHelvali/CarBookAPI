using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.FooterAdress.GetFooterAddress
{
    public class GetFooterAddressQueryRequest:IRequest<List<GetFooterAddressQueryResponse>>
    {
    }
}