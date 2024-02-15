using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Pricing.GetPricingById
{
    public class GetPricingByIdQueryHandler : IRequestHandler<GetPricingByIdQueryRequest, GetPricingByIdQueryResponse>
    {
        private readonly IRepository<Domain.Entities.Pricing> _repository;

        public GetPricingByIdQueryHandler(IRepository<Domain.Entities.Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<GetPricingByIdQueryResponse> Handle(GetPricingByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            return new ()
            {
                PricingId=value.PricingId,
                Name=value.Name,
            };
        }
    }
}
