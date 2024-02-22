using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Blog.RemoveBlog
{
    public class RemoveBlogCommandRequest:IRequest
    {
        public int ID { get; set; }

        public RemoveBlogCommandRequest(int id)
        {
            ID = id;
        }
    }
}