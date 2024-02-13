using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Banner.UpdateBanner
{
    public class UpdateBannerCommandHandler
    {
        private readonly IRepository<Domain.Entities.Banner> _repository;

        public UpdateBannerCommandHandler(IRepository<Domain.Entities.Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBannerCommandRequest request)
        {
            var values = await _repository.GetByIdAsync(request.BannerID);
            values.Description=request.Description;
            values.VideoDescription=request.VideoDescription;
            values.VideoUrl=request.VideoUrl;
            values.Title=request.Title;
            await _repository.UpdateAsync(values);

        }
    }
}
