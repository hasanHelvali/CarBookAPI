using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Feature.GetFeatureById
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQueryRequest, GetFeatureByIdQueryResponse>
    {
        private readonly IRepository<Domain.Entities.Feature> _repository;

        public GetFeatureByIdQueryHandler(IRepository<Domain.Entities.Feature> repository)
        {
            _repository = repository;
        }

        public async Task<GetFeatureByIdQueryResponse> Handle(GetFeatureByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            return new GetFeatureByIdQueryResponse()
            {
                FeatureId = value.FeatureId,
                Name = value.Name,
            };
        }
    }
}
