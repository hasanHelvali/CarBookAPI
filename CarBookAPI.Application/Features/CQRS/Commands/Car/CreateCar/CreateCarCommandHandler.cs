using CarBookAPI.Application.Features.CQRS.Commands.Brand.CreateBrandCommand;
using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Car.CreateCar
{
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Domain.Entities.Car> _repository;

        public CreateCarCommandHandler(IRepository<Domain.Entities.Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarCommandRequest request)
        {
            await _repository.CreateAsync(new Domain.Entities.Car
            {
                Transmission=request.Transmission,
                Seat=request.Seat,
                Model=request.Model,
                Luggage=request.Luggage,
                Km = request.Km,
                Fuel=request.Fuel,
                BigImageUrl=request.BigImageUrl,
                BrandID=request.BrandID,
                CoverImageUrl=request.CoverImageUrl,
            });
        }
    }
}
