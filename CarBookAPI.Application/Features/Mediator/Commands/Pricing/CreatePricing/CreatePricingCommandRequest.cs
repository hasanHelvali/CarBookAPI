using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Pricing.CreatePricing
{
    public class CreatePricingCommandRequest:IRequest
    {
        public string Name { get; set; }
    }
}