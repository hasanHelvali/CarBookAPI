using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.TagCloud.GetTagCloud
{
    public class GetTagCloudQueryResponse
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}