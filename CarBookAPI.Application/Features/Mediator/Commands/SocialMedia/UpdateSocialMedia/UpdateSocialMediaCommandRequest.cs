using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.SocialMedia.UpdateSocialMedia
{
    public class UpdateSocialMediaCommandRequest:IRequest
    {
        public int SocialMediaID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
    }
}