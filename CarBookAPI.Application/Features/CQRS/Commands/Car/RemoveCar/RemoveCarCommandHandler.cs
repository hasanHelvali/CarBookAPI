using CarBookAPI.Application.Features.CQRS.Commands.Brand.RemoveBrandCommand;
using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Car.RemoveCar
{
    public class RemoveCarCommandHandler
    {
        private readonly IRepository<Domain.Entities.Car> _repository;

        public RemoveCarCommandHandler(IRepository<Domain.Entities.Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCarCommandRequest request)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);

        }
    }
}
