using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Location.UpdateLocation
{
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Location> _repository;

        public UpdateLocationCommandHandler(IRepository<Domain.Entities.Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateLocationCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.LocationID);
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
        }
    }
}
