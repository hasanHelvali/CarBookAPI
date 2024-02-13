using CarBookAPI.Application.Features.CQRS.Queries.Category.GetCategory;
using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Category.GetCategory
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Domain.Entities.Category> _repository;

        public GetCategoryQueryHandler(IRepository<Domain.Entities.Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryQueryResponse>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCategoryQueryResponse
            {
                CategoryID = x.CategoryID,
                Name=x.Name,
            }).ToList();
        }
    }
}
