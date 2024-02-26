using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.TagCloud.GetTagCloud
{
    public class GetTagCloudQueryRequest : IRequest<List<GetTagCloudQueryResponse>>
    {
    }
}