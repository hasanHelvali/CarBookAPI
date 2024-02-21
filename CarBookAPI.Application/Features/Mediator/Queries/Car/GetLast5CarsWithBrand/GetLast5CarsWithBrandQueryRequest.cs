using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Car.Get5LastCarsWithBrand
{
    public class GetLast5CarsWithBrandQueryRequest:IRequest<List<GetLast5CarsWithBrandQueryResponse>>
    {
    }
}