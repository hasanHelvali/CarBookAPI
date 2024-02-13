using CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrandById;
using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Car.GetCarById
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Domain.Entities.Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Domain.Entities.Car> repository)
        {
            _repository = repository;
        }

        public async Task<GetCarByIdQueryResponse> Handle(GetCarByIdQueryRequest request)
        {
            var values = await _repository.GetByIdAsync(request.ID);
            return new GetCarByIdQueryResponse
            {
                BrandID = values.BrandID,
                BigImageUrl = values.BigImageUrl,
                CoverImageUrl = values.CoverImageUrl,
                Fuel=values.Fuel,
                Km = values.Km,
                Luggage = values.Luggage,
                Model = values.Model,
                Seat = values.Seat,
                Transmission = values.Transmission,
                CarID = values.CarID
                
            };
        }
    }
}
