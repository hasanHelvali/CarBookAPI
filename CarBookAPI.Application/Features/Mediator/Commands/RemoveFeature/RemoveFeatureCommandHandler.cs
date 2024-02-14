using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.RemoveFeature
{
    public class RemoveFeatureCommandHandler : IRequestHandler<RemoveFeatureCommandRequest>
    {
        private readonly IRepository<Feature> _repository;

        public RemoveFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFeatureCommandRequest request, CancellationToken cancellationToken)
        {
            Feature feature = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(feature);
        }
    }
}
