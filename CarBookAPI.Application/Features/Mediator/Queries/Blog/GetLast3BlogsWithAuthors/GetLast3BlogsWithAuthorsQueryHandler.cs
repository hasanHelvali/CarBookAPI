using CarBookAPI.Application.Features.Mediator.Queries.Car.Get5LastCarsWithBrand;
using CarBookAPI.Application.Interfaces;
using CarBookAPI.Application.Interfaces.BlogInterfaces;
using CarBookAPI.Application.Interfaces.CarInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Blog.GetLast3BlogsWithAuthors
{
    public class GetLast3BlogsWithAuthorsQueryHandler : IRequestHandler<GetLast3BlogsWithAuthorsQueryRequest, List<GetLast3BlogsWithAuthorsQueryResponse>>
    {
        private readonly IBlogRepository _repository;

        public GetLast3BlogsWithAuthorsQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogsWithAuthorsQueryResponse>> Handle(GetLast3BlogsWithAuthorsQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetLast3BlogsWithAuthors();
            return values.Select(x => new GetLast3BlogsWithAuthorsQueryResponse
            {
                BlogID=x.BlogID,
                AuthorID=x.AuthorID,
                CategoryID=x.CategoryID,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Title = x.Title,
                AuthorName=x.Author.Name
            }).ToList();
        }
    }
}
