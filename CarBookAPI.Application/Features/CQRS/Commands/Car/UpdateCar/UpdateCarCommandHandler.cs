using CarBookAPI.Application.Features.CQRS.Commands.Brand.UpdateBrandCommand;
using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Car.UpdateCar
{
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Domain.Entities.Car> _repository;

        public UpdateCarCommandHandler(IRepository<Domain.Entities.Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommandRequest request)
        {
            var values = await _repository.GetByIdAsync(request.BrandID);
            values.Fuel = request.Fuel;
            values.Transmission = request.Transmission;
            values.CoverImageUrl = request.CoverImageUrl;
            values.Km=request.Km;
            values.Luggage = request.Luggage;
            values.Model = request.Model;
            values.BigImageUrl= request.BigImageUrl;
            values.BrandID= request.BrandID;
            values.Seat= request.Seat;
            await _repository.UpdateAsync(values);

        }
    }
}
