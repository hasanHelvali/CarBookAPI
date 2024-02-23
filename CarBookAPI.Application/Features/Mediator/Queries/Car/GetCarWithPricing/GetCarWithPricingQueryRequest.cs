using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Car.GetCarWithPricing
{
    public class GetCarWithPricingQueryRequest:IRequest<List<GetCarWithPricingQueryResponse>>
    {

    }
}