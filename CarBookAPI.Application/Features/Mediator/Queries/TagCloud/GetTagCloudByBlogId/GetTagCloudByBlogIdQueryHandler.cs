using CarBookAPI.Application.Interfaces.TagCloudInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.TagCloud.GetTagCloudByBlogId
{
    public class GetTagCloudByBlogIdQueryHandler : IRequestHandler<GetTagCloudByBlogIdQueryRequest, List<GetTagCloudByBlogIdQueryResponse>>
    {
        private readonly ITagCloudRepository _tagCloudRepository;

        public GetTagCloudByBlogIdQueryHandler(ITagCloudRepository tagCloudRepository)
        {
            _tagCloudRepository = tagCloudRepository;
        }

        public async Task<List<GetTagCloudByBlogIdQueryResponse>> Handle(GetTagCloudByBlogIdQueryRequest request, CancellationToken cancellationToken)
        {
            var values =await _tagCloudRepository.GetTagCloudsByBlogID(request.ID);
            return values.Select(x => new GetTagCloudByBlogIdQueryResponse
            {
                ID = x.ID,
                BlogId = x.BlogId,
                Title = x.Title,
            }).ToList();
        }
    }
}
