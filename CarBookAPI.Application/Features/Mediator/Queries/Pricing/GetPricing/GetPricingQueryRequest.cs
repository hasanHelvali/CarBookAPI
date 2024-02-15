using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Pricing.GetPricing
{
    public class GetPricingQueryRequest:IRequest<List<GetPricingQueryResponse>>
    {
    }
}