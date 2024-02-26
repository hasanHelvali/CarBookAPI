using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.TagCloud.GetTagCloudByBlogId
{
    public class GetTagCloudByBlogIdQueryRequest:IRequest<List<GetTagCloudByBlogIdQueryResponse>>
    {
        public int ID { get; set; }

        public GetTagCloudByBlogIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}