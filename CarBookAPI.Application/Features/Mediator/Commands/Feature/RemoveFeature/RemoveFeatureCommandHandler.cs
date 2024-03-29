﻿using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Feature.RemoveFeature
{
    public class RemoveFeatureCommandHandler : IRequestHandler<RemoveFeatureCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Feature> _repository;

        public RemoveFeatureCommandHandler(IRepository<Domain.Entities.Feature> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFeatureCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Feature feature = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(feature);
        }
    }
}
