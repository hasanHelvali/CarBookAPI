using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Author.RemoveAuthor
{
    public class RemoveAuthorCommandRequest:IRequest
    {
        public int ID { get; set; }

        public RemoveAuthorCommandRequest(int id)
        {
            ID = id;
        }
    }
}