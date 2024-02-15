using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.SocialMedia.GetSocialMedia
{
    public class GetSocialMediaQueryRequest:IRequest<List<GetSocialMediaQueryResponse>>
    {
    }
}