using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Banner.CreateBanner
{
    public class CreateBannerCommandHandler
    {
        private readonly IRepository<Domain.Entities.Banner> _repository;

        public CreateBannerCommandHandler(IRepository<Domain.Entities.Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBannerCommandRequest request)
        {
            await _repository.CreateAsync(new Domain.Entities.Banner
            {
                Title = request.Title,
                Description = request.Description,
                VideoDescription = request.VideoDescription,
                VideoUrl = request.VideoUrl,
            });
        }
    }
}
