using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.SocialMedia.GetByIdSocialMedia
{
    public class GetByIdSocialMediaQueryRequest:IRequest<GetByIdSocialMediaQueryResponse>
    {
        public int ID { get; set; }

        public GetByIdSocialMediaQueryRequest(int id)
        {
            ID = id;
        }
    }
}