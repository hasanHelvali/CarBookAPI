using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Pricing.GetPricingById
{
    public class GetPricingByIdQueryRequest:IRequest<GetPricingByIdQueryResponse>
    {
        public int ID { get; set; }

        public GetPricingByIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}