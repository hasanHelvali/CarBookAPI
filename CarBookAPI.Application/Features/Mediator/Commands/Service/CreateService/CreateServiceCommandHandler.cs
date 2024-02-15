using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Service.CreateService
{
    public class CreateServiceCommandHandler : IRequestHandler<CreateServiceCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Service> _repository;

        public CreateServiceCommandHandler(IRepository<Domain.Entities.Service> repository)
        {
            this._repository = repository;
        }

        public async Task Handle(CreateServiceCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Domain.Entities.Service
            {
                Description = request.Description,
                IconUrl = request.IconUrl,
                Title = request.Title,
            });
        }
    }
}
