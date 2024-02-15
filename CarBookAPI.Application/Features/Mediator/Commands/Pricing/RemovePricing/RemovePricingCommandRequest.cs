using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Pricing.RemovePricing
{
    public class RemovePricingCommandRequest:IRequest
    {
        public int ID { get; set; }

        public RemovePricingCommandRequest(int id)
        {
            ID = id;
        }
    }
}