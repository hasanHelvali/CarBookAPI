using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Pricing.RemovePricing
{
    public class RemovePricingCommandHandler : IRequestHandler<RemovePricingCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Pricing> _repository;

        public RemovePricingCommandHandler(IRepository<Domain.Entities.Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemovePricingCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);
        }
    }
}
