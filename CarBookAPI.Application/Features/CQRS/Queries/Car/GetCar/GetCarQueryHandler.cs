using CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrand;
using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Car.GetCar
{
    public class GetCarQueryHandler
    {

        private readonly IRepository<Domain.Entities.Car> _repository;

        public GetCarQueryHandler(IRepository<Domain.Entities.Car> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCarQueryResponse>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCarQueryResponse
            {
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
