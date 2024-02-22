using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Author.UpdateAuthor
{
    public class UpdateAuthorCommandRequest:IRequest
    {
            public int AuthorID { get; set; }
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public string Description { get; set; }
    }
}