using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Service.GetService
{
    public class GetServiceQueryRequest:IRequest<List<GetServiceQueryResponse>>
    {

    }
}