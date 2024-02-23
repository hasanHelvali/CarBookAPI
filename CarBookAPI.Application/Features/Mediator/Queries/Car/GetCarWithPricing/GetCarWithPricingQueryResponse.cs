using CarBookAPI.Domain.Entities;

namespace CarBookAPI.Application.Features.Mediator.Queries.Car.GetCarWithPricing
{
    public class GetCarWithPricingQueryResponse
    {
        public int CarPricingID { get; set; }
        public string Brand{ get; set; }
        public string Model{ get; set; }
        public decimal Amount{ get; set; }
        public string CoverImageUrl { get; set; }

    }
}