using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Pricing.GetPricing
{
    public class GetPricingQueryHandler : IRequestHandler<GetPricingQueryRequest, List<GetPricingQueryResponse>>
    {
        private readonly IRepository<Domain.Entities.Pricing> _repository;

        public GetPricingQueryHandler(IRepository<Domain.Entities.Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPricingQueryResponse>> Handle(GetPricingQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetPricingQueryResponse
            {
                PricingId = x.PricingId,
                Name = x.Name,
            }).ToList();
        }
    }
}
