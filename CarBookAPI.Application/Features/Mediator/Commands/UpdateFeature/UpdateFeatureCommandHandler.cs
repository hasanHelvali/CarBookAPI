﻿using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.UpdateFeature
{
    public class UpdateFeatureCommandHandler : IRequestHandler<UpdateFeatureCommandRequest, UpdateFeatureCommandResponse>
    {
        private readonly IRepository<Feature> _repository;

        public UpdateFeatureCommandHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<UpdateFeatureCommandResponse> Handle(UpdateFeatureCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.FeatureId);
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
            return new UpdateFeatureCommandResponse();
        }
    }
}
