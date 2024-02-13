using CarBookAPI.Application.Features.CQRS.Queries.Car.GetCar;
using CarBookAPI.Application.Interfaces;
using CarBookAPI.Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.GetCarWithBrand
{
    public class GetCarWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetCarWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public async Task<List<GetCarWithBrandQueryResponse>> Handle()
        {
            var values =  await _carRepository.GetCarsListWithBrand();
            return values.Select(x => new GetCarWithBrandQueryResponse
            {
                BrandName=x.Brand.Name,
                BrandID = x.BrandID,
                BigImageUrl = x.BigImageUrl,
                CarID = x.CarID,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission

            }).ToList();
        }
    }
}
