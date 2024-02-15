using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Pricing.UpdatePricing
{
    public class UpdatePricingCommandRequest:IRequest
    {
        public int PricingId { get; set; }
        public string Name { get; set; }
    }
}