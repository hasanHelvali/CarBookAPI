using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Location.CreateLocation
{
    public class CreateLocationCommandHandler : IRequestHandler<CreateLocationCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Location> _repository;

        public CreateLocationCommandHandler(Interfaces.IRepository<Domain.Entities.Location> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateLocationCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Domain.Entities.Location
            {
                Name = request.Name
            });
        }
    }
}
