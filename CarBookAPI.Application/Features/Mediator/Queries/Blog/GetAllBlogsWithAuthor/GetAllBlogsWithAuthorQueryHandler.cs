using CarBookAPI.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Blog.GetAllBlogsWithAuthor
{
    public class GetAllBlogsWithAuthorQueryHandler : IRequestHandler<GetAllBlogsWithAuthorQueryRequest, List<GetAllBlogsWithAuthorQueryResponse>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetAllBlogsWithAuthorQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetAllBlogsWithAuthorQueryResponse>> Handle(GetAllBlogsWithAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _blogRepository.GetAllBlogsWithAuthors();
            return values.Select(x=>new GetAllBlogsWithAuthorQueryResponse
            {
                AuthorID = x.AuthorID,
                AuthorName=x.Author.Name,
                BlogID=x.BlogID,
                CategoryID=x.CategoryID,
                //CategoryName=x.Category.Name,
                CoverImageUrl=x.CoverImageUrl,
                CreatedDate=x.CreatedDate,
                Description=x.Description,
                Title=x.Title,
                AuthorDescription=x.Author.Description,
                AuthorImageUrl=x.Author.ImageUrl,
            }).ToList();
        }
    }
}
