using CarBookAPI.Application.Features.CQRS.Commands.Banner.RemoveBanner;
using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Brand.RemoveBrandCommand
{
    public class RemoveBrandCommandHandler
    {
        private readonly IRepository<Domain.Entities.Brand> _repository;

        public RemoveBrandCommandHandler(IRepository<Domain.Entities.Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBrandCommandRequest request)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);

        }
    }
}
