using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.SocialMedia.RemoveSocialMedia
{
    public class RemoveSocialMediaCommandRequest:IRequest
    {
        public int ID { get; set; }

        public RemoveSocialMediaCommandRequest(int id)
        {
            ID = id;
        }
    }
}