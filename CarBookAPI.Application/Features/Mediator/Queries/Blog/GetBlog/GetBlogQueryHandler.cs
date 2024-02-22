using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Blog.GetBlog
{
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQueryRequest, List<GetBlogQueryResponse>>
    {
        private readonly IRepository<Domain.Entities.Blog> _repository;

        public GetBlogQueryHandler(IRepository<Domain.Entities.Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogQueryResponse>> Handle(GetBlogQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(c => new GetBlogQueryResponse
            {
                AuthorID = c.AuthorID,
                BlogID = c.BlogID,
                CategoryID = c.CategoryID,
                CoverImageUrl = c.CoverImageUrl,
                CreatedDate = c.CreatedDate,
                Title = c.Title,
            }).ToList();
        }
    }
}
