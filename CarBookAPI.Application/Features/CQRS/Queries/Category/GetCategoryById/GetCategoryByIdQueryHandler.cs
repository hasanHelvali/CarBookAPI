using CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrandById;
using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Category.GetCategoryById
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Domain.Entities.Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Domain.Entities.Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResponse> Handle(GetCategoryByIdQueryRequest request)
        {
            var values = await _repository.GetByIdAsync(request.ID);
            return new GetCategoryByIdQueryResponse
            {
                ID=values.CategoryID,
                Name = values.Name,
            };
        }
    }
}
