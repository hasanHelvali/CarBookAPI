using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.TagCloud.RemoveTagCloud
{
    public class RemoveTagCloudCommandRequest:IRequest
    {
        public int ID { get; set; }

        public RemoveTagCloudCommandRequest(int id)
        {
            ID = id;
        }
    }
}