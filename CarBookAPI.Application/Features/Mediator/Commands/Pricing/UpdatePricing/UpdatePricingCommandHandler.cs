using CarBookAPI.Application.Interfaces;
using CarBookAPI.Application.Interfaces.CarInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Pricing.UpdatePricing
{
    public class UpdatePricingCommandHandler : IRequestHandler<UpdatePricingCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Pricing> _repository;

        public UpdatePricingCommandHandler(IRepository<Domain.Entities.Pricing> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdatePricingCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.PricingId);
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
        }
    }
}
