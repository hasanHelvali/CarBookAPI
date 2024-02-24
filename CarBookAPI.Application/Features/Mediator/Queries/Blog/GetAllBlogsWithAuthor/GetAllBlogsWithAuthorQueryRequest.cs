using CarBookAPI.Domain.Entities;
using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Blog.GetAllBlogsWithAuthor
{
    public class GetAllBlogsWithAuthorQueryRequest : IRequest<List<GetAllBlogsWithAuthorQueryResponse>>
    {

    }
}