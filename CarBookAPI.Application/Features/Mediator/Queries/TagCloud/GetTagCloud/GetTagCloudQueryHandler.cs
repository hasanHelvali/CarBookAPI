using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.TagCloud.GetTagCloud
{
    public class GetTagCloudQueryHandler : IRequestHandler<GetTagCloudQueryRequest, List<GetTagCloudQueryResponse>>
    {
        private readonly IRepository<Domain.Entities.TagCloud> _repository;

        public GetTagCloudQueryHandler(IRepository<Domain.Entities.TagCloud> repository)
        {
            this._repository = repository;
        }

        public async Task<List<GetTagCloudQueryResponse>> Handle(GetTagCloudQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=>new GetTagCloudQueryResponse
            {
                BlogID = x.BlogId,
                ID = x.ID,
                Title=x.Title,
            }).ToList();
        }
    }
}
