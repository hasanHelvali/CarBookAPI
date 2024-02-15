using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.FooterAdress.GetFooterAddressById
{
    public class GetFooterAddressByIdQueryRequest:IRequest<GetFooterAddressByIdQueryResponse>
    {
        public int ID { get; set; }

        public GetFooterAddressByIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}