using CarBookAPI.Application.Features.CQRS.Queries.Car.GetCarById;
using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.TagCloud.GetTagCloudById
{
    public class GetTagCloudByIdQueryHandler : IRequestHandler<GetTagCloudByIdQueryRequest, GetTagCloudByIdQueryResponse>
    {
        private readonly IRepository<Domain.Entities.TagCloud> _repository;

        public GetTagCloudByIdQueryHandler(IRepository<Domain.Entities.TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagCloudByIdQueryResponse> Handle(GetTagCloudByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            return new GetTagCloudByIdQueryResponse
            {
                BlogID = value.BlogId,
                ID = value.ID,
                Title = value.Title,
            };
        }
    }
}
