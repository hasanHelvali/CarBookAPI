using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Service.UpdateService
{
    public class UpdateServiceCommandHandler : IRequestHandler<UpdateServiceCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Service> _repository;

        public UpdateServiceCommandHandler(IRepository<Domain.Entities.Service> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateServiceCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ServiceId);
            value.Description = request.Description;
            value.Title = request.Title;
            value.IconUrl = request.IconUrl;
            await _repository.UpdateAsync(value);
        }
    }
}
