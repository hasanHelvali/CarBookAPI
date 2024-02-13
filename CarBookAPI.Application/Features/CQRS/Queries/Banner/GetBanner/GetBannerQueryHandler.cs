using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Banner.GetBanner
{
    public class GetBannerQueryHandler
    {
        private readonly IRepository<Domain.Entities.Banner> _repository;

        public GetBannerQueryHandler(IRepository<Domain.Entities.Banner> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBannerQueryResponse>> Handle()
        {

            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetBannerQueryResponse
            {
                BannerID = x.BannerID,
                Description = x.Description,
                Title = x.Title,
                VideoDescription = x.VideoDescription,
                VideoUrl = x.VideoUrl,

            }).ToList();

        }
    }
}
