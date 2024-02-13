using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Banner.RemoveBanner
{
    public class RemoveBannerCommandHandler
    {
        private readonly IRepository<Domain.Entities.Banner> _repository;

        public RemoveBannerCommandHandler(IRepository<Domain.Entities.Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBannerCommandRequest request)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);

        }
    }
}
