using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Service.GetService
{
    public class GetServiceQueryHandler : IRequestHandler<GetServiceQueryRequest, List<GetServiceQueryResponse>>
    {
        private readonly IRepository<Domain.Entities.Service> _repository;

        public GetServiceQueryHandler(Interfaces.IRepository<Domain.Entities.Service> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetServiceQueryResponse>> Handle(GetServiceQueryRequest request, CancellationToken cancellationToken)
        {

            List<Domain.Entities.Service> values = await _repository.GetAllAsync();
            return values.Select(x => new GetServiceQueryResponse
            {
                Description = x.Description,
                IconUrl = x.IconUrl,
                ServiceId = x.ServiceId,
                Title = x.Title,
            }).ToList();

            //var value = await _repository.GetAllAsync();
            //return value.Select(x=>new GetServiceQueryResponse
            //{
            //    Description = x.Description,
            //    IconUrl = x.IconUrl,
            //    ServiceId = x.ServiceId,
            //    Title = x.Title,
            //}).ToList();
        }
    }
}
