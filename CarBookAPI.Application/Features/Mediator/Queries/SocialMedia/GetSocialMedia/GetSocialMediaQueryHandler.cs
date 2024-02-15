using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.SocialMedia.GetSocialMedia
{
    public class GetSocialMediaQueryHandler : IRequestHandler<GetSocialMediaQueryRequest, List<GetSocialMediaQueryResponse>>
    {
        private readonly IRepository<Domain.Entities.SocialMedia> _repository;

        public GetSocialMediaQueryHandler(IRepository<Domain.Entities.SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetSocialMediaQueryResponse>> Handle(GetSocialMediaQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetSocialMediaQueryResponse
            {
                Icon = x.Icon,
                Name = x.Name,
                SocialMediaID = x.SocialMediaID,
                Url = x.Url,
            }).ToList();
        }
    }
}
