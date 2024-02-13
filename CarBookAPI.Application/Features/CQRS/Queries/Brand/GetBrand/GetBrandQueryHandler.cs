using CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrandById;
using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrand
{
    public class GetBrandQueryHandler
    {
        private readonly IRepository<Domain.Entities.Brand> _repository;

        public GetBrandQueryHandler(IRepository<Domain.Entities.Brand> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBrandQueryResponse>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBrandQueryResponse
            {
                BrandID = x.BrandID,
                Name = x.Name,
            }).ToList();
        }
    }
}
