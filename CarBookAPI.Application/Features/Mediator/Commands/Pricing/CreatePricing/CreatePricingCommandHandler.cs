using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Pricing.CreatePricing
{
    public class CreatePricingCommandHandler : IRequestHandler<CreatePricingCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Pricing> _repository;

        public CreatePricingCommandHandler(IRepository<Domain.Entities.Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreatePricingCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Domain.Entities.Pricing
            {
                Name = request.Name,
            });
            
        }
    }
}
