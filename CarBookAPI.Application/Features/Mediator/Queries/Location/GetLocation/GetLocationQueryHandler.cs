using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Location.GetLocation
{
    public class GetLocationQueryHandler : IRequestHandler<GetLocationQueryRequest, List<GetLocationQueryResponse>>
    {
        private readonly IRepository<Domain.Entities.Location> _repository;

        public GetLocationQueryHandler(IRepository<Domain.Entities.Location> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLocationQueryResponse>> Handle(GetLocationQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(c=>new GetLocationQueryResponse
            {
                LocationID=c.LocationID,
                Name=c.Name,
            }).ToList();
        }
    }
}
