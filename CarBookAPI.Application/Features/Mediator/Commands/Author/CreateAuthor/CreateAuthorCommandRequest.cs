using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Author.CreateAuthor
{
    public class CreateAuthorCommandRequest:IRequest
    {
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public string Description { get; set; }
    }
}