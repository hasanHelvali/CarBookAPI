using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Service.RemoveService
{
    public class RemoveServiceCommandHandler : IRequestHandler<RemoveServiceCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Service> _repository;

        public RemoveServiceCommandHandler(IRepository<Domain.Entities.Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveServiceCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);
        }
    }
}
