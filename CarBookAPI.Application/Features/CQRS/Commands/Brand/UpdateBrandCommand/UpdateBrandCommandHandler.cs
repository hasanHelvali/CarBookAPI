using CarBookAPI.Application.Features.CQRS.Commands.Banner.UpdateBanner;
using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Brand.UpdateBrandCommand
{
    public class UpdateBrandCommandHandler
    {
        private readonly IRepository<Domain.Entities.Brand> _repository;

        public UpdateBrandCommandHandler(IRepository<Domain.Entities.Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBrandCommandRequest request)
        {
            var values = await _repository.GetByIdAsync(request.BrandID);
            values.Name = request.Name;
            await _repository.UpdateAsync(values);

        }
    }
}
