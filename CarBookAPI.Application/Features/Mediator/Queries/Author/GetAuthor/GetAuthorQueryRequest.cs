using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Author.GetAuthor
{
    public class GetAuthorQueryRequest:IRequest<List<GetAuthorQueryResponse>>
    {
    }
}