using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Category.UpdateCategory
{
    public class UpdateCategoryCommandHandler
    {
        private readonly IRepository<Domain.Entities.Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Domain.Entities.Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCategoryCommandRequest request)
        {
            var values = await _repository.GetByIdAsync(request.ID);
            values.Name = request.Name;
            await _repository.UpdateAsync(values);

        }
    }
}
