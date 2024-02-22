using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Blog.GetLast3BlogsWithAuthors
{
    public class GetLast3BlogsWithAuthorsQueryRequest:IRequest<List<GetLast3BlogsWithAuthorsQueryResponse>>
    {

    }
}