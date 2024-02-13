using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrandById
{
    public class GetBrandByIdQueryHandler
    {
        private readonly IRepository<Domain.Entities.Brand> _repository;

        public GetBrandByIdQueryHandler(IRepository<Domain.Entities.Brand> repository)
        {
            _repository = repository;
        }

        public async Task<GetBrandByIdQueryResponse> Handle(GetBrandByIdQueryRequest request)
        {
            var values = await _repository.GetByIdAsync(request.ID);
            return new GetBrandByIdQueryResponse
            {
                
                BrandID = values.BrandID,
                Name = values.Name,
            };
        }
    }
}
