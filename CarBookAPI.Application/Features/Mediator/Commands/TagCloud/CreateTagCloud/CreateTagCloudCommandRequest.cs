using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.TagCloud.CreateTagCloud
{
    public class CreateTagCloudCommandRequest:IRequest
    {
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}