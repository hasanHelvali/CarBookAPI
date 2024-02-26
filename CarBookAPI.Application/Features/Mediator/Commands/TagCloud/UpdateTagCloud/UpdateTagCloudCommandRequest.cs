using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.TagCloud.UpdateTagCloud
{
    public class UpdateTagCloudCommandRequest : IRequest
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int BlogID { get; set; }
    }
}