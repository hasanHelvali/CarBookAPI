using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.SocialMedia.GetByIdSocialMedia
{
    public class GetByIdSocialMediaQueryHandler : IRequestHandler<GetByIdSocialMediaQueryRequest, GetByIdSocialMediaQueryResponse>
    {
        private readonly IRepository<Domain.Entities.SocialMedia> _repository;

        public GetByIdSocialMediaQueryHandler(IRepository<Domain.Entities.SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task<GetByIdSocialMediaQueryResponse> Handle(GetByIdSocialMediaQueryRequest request, CancellationToken cancellationToken)
        {
            var value =await _repository.GetByIdAsync(request.ID);
            return new GetByIdSocialMediaQueryResponse
            {
                Icon = value.Icon,
                Name = value.Name,
                SocialMediaID = value.SocialMediaID,
                Url = value.Url,
            };
        }
    }
}
