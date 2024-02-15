using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Location.RemoveLocation
{
    public class RemoveLocationCommandHandler : IRequestHandler<RemoveLocationCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Location> _repository;

        public RemoveLocationCommandHandler(IRepository<Domain.Entities.Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveLocationCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);
        }
    }
}
