using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Location.GetLocation
{
    public class GetLocationQueryRequest:IRequest<List<GetLocationQueryResponse>>
    {
    }
}