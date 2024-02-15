using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.SocialMedia.CreateSocialMedia
{
    public class CreateSocialMediaCommandRequest:IRequest
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}