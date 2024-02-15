using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Service.GetServiceById
{
    public class GetServiceByIdQueryRequest:IRequest<GetServiceByIdQueryResponse>
    {
        public int ID { get; set; }

        public GetServiceByIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}