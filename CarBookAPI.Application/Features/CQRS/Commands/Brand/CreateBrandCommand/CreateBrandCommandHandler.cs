using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Brand.CreateBrandCommand
{
    public class CreateBrandCommandHandler
    {
        private readonly IRepository<Domain.Entities.Brand> _repository;

        public CreateBrandCommandHandler(IRepository<Domain.Entities.Brand> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBrandCommandRequest request)
        {
            await _repository.CreateAsync(new Domain.Entities.Brand
            {
                Name = request.Name
            });
        }
    }
}
