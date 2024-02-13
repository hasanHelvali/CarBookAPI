using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Category.RemoveCategory
{
    public class RemoveCategoryCommandHandler
    {
        private readonly IRepository<Domain.Entities.Category> _repository;

        public RemoveCategoryCommandHandler(IRepository<Domain.Entities.Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveCategoryCommandRequest request)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);

        }
    }
}
