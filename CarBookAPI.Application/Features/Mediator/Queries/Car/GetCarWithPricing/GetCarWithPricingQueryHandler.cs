using CarBookAPI.Application.Interfaces.CarInterfaces;
using CarBookAPI.Application.Interfaces.CarPricingInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Car.GetCarWithPricing
{
    public class GetCarWithPricingQueryHandler : IRequestHandler<GetCarWithPricingQueryRequest, List<GetCarWithPricingQueryResponse>>
    {
        private readonly ICarPricingRepository _carPricingRepository;

        public GetCarWithPricingQueryHandler(ICarPricingRepository carPricingRepository)
        {
            _carPricingRepository = carPricingRepository;
        }

        public async Task<List<GetCarWithPricingQueryResponse>> Handle(GetCarWithPricingQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _carPricingRepository.GetCarPricingWithCars();
            return values.Select(x => new GetCarWithPricingQueryResponse
            {
                Amount = x.Amount,
                Brand = x.Car.Brand.Name,
                CoverImageUrl = x.Car.CoverImageUrl,
                Model = x.Car.Model,
                CarPricingID = x.CarPricingID
            }).ToList();
        }
    }
}
