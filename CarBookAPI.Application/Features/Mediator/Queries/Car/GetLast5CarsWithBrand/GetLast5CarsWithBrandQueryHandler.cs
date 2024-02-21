using CarBookAPI.Application.Interfaces.CarInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Car.Get5LastCarsWithBrand
{
    public class GetLast5CarsWithBrandQueryHandler : IRequestHandler<GetLast5CarsWithBrandQueryRequest, List<GetLast5CarsWithBrandQueryResponse>>
    {
        private readonly ICarRepository _carRepository;

        public GetLast5CarsWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<GetLast5CarsWithBrandQueryResponse>> Handle(GetLast5CarsWithBrandQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _carRepository.GetLast5CarsWithBrands();
            return values.Select(x => new GetLast5CarsWithBrandQueryResponse
            {
                BigImageUrl = x.BigImageUrl,
                BrandID = x.BrandID,
                BrandName = x.Brand.Name,
                CarID = x.CarID,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission,
            }).ToList();
        }
    }
}
