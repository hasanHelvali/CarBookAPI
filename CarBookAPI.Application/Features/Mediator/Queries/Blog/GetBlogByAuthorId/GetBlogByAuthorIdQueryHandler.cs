using CarBookAPI.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Blog.GetBlogByAuthorId
{
    public class GetBlogByAuthorIdQueryHandler : IRequestHandler<GetBlogByAuthorIdQueryRequest, List<GetBlogByAuthorIdQueryResponse>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetBlogByAuthorIdQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetBlogByAuthorIdQueryResponse>> Handle(GetBlogByAuthorIdQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _blogRepository.GetBlogsByAuthorId(request.ID);
            return values.Select(x=> new GetBlogByAuthorIdQueryResponse
            {
                AuthorDescription=x.Author.Description,
                AuthorID = x.AuthorID,
                AuthorImageUrl=x.Author.ImageUrl,
                AuthorName=x.Author.Name,
                BlogID=x.BlogID,
            }).ToList();
        }
    }
}
