using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.TagCloud.GetTagCloudById
{
    public class GetTagCloudByIdQueryRequest:IRequest<GetTagCloudByIdQueryResponse>
    {
        public int ID { get; set; }

        public GetTagCloudByIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}