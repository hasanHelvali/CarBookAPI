using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.GetFeature
{
    public class GetFeatureQueryHandler : IRequestHandler<GetFeatureQueryRequest, List<GetFeatureQueryResponse>>
    {
        private readonly IRepository<Feature> _repository;

        public GetFeatureQueryHandler(IRepository<Feature> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFeatureQueryResponse>> Handle(GetFeatureQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetFeatureQueryResponse
            {
                FeatureId = x.FeatureId,
                Name = x.Name,
            }).ToList(); 
        }
    }
}
