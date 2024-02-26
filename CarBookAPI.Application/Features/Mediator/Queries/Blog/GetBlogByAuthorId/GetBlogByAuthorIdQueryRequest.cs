using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Blog.GetBlogByAuthorId
{
    public class GetBlogByAuthorIdQueryRequest:IRequest<List<GetBlogByAuthorIdQueryResponse>>
    {
        public int ID { get; set; }

        public GetBlogByAuthorIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}