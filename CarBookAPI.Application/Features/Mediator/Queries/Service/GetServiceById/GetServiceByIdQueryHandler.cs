using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Service.GetServiceById
{
    public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQueryRequest, GetServiceByIdQueryResponse>
    {
        private readonly IRepository<Domain.Entities.Service> _repository;

        public GetServiceByIdQueryHandler(IRepository<Domain.Entities.Service> repository)
        {
            _repository = repository;
        }

        public async Task<GetServiceByIdQueryResponse> Handle(GetServiceByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            return new GetServiceByIdQueryResponse
            {
                Description = value.Description,
                IconUrl = value.IconUrl,
                ServiceId = value.ServiceId,
                Title = value.Title
            };
        }
    }
}
