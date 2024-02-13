using CarBookAPI.Application.Features.CQRS.Queries.About.GetAboutById;
using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Banner.GetBannerById
{
    public class GetBannerByIdQueryHandler
    {
        private readonly IRepository<Domain.Entities.Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Domain.Entities.Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIdQueryResponse>Handle(GetBannerByIdQueryRequest request)
        {
            var values = await _repository.GetByIdAsync(request.ID);
            return new GetBannerByIdQueryResponse
            {
                BannerID = values.BannerID,
                Description = values.Description,
                Title = values.Title,
                VideoDescription = values.VideoDescription,
                VideoUrl = values.VideoUrl,
            };
        }
    }
}
