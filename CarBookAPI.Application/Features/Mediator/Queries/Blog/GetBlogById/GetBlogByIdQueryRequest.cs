using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Blog.GetBlogById
{
    public class GetBlogByIdQueryRequest:IRequest<GetBlogByIdQueryResponse>
    {
        public int ID { get; set; }

        public GetBlogByIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}