using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Contact.RemoveContact
{
    public class RemoveContactCommandHandler
    {
        private readonly IRepository<Domain.Entities.Contact> _repository;

        public RemoveContactCommandHandler(IRepository<Domain.Entities.Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveContactCommandRequest request)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);

        }
    }
}
