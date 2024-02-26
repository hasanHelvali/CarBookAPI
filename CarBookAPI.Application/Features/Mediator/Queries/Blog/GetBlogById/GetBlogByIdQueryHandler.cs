using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Blog.GetBlogById
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQueryRequest, GetBlogByIdQueryResponse>
    {
        private readonly IRepository<Domain.Entities.Blog> _repository;

        public GetBlogByIdQueryHandler(IRepository<Domain.Entities.Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResponse> Handle(GetBlogByIdQueryRequest request, CancellationToken cancellationToken)
        {

            var value = await _repository.GetByIdAsync(request.ID);
            return new GetBlogByIdQueryResponse()
            {
                AuthorID = value.AuthorID,
                Title = value.Title,
                BlogID = value.BlogID,
                CategoryID = value.CategoryID,
                CoverImageUrl = value.CoverImageUrl,
                CreatedDate = value.CreatedDate,
                Description=value.Description
            };
        }
    }
}
