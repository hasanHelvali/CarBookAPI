using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Blog.GetBlog
{
    public class GetBlogQueryRequest:IRequest<List<GetBlogQueryResponse>>
    {

    }
}