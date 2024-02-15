using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Location.GetLocationById
{
    public class GetLocationByIdQueryRequest:IRequest<GetLocationByIdQueryResponse>
    {
        public int ID { get; set; }

        public GetLocationByIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}