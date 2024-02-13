using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Category.CreateCategory
{
    public class CreateCategoryCommandHandler
    {
        private readonly IRepository<Domain.Entities.Category> _repository;

        public CreateCategoryCommandHandler(IRepository<Domain.Entities.Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCategoryCommandRequest request)
        {
            await _repository.CreateAsync(new Domain.Entities.Category
            {
                Name = request.Name
            });
        }
    }
}
