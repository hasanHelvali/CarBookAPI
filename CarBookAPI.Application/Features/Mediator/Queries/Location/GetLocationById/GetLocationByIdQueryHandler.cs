using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Location.GetLocationById
{
    public class GetLocationByIdQueryHandler : IRequestHandler<GetLocationByIdQueryRequest, GetLocationByIdQueryResponse>
    {
        private readonly IRepository<Domain.Entities.Location> _repository;

        public GetLocationByIdQueryHandler(Interfaces.IRepository<Domain.Entities.Location> repository)
        {
            _repository = repository;
        }

        public async Task<GetLocationByIdQueryResponse> Handle(GetLocationByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            return new GetLocationByIdQueryResponse
            {
                LocationID = value.LocationID,
                Name= value.Name,
            };
        }
    }
}
