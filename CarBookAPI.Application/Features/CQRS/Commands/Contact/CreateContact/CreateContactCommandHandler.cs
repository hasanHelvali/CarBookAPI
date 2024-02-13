using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Contact.CreateContact
{
    public class CreateContactCommandHandler
    {
        private readonly IRepository<Domain.Entities.Contact> _repository;

        public CreateContactCommandHandler(IRepository<Domain.Entities.Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactCommandRequest request)
        {
            await _repository.CreateAsync(new Domain.Entities.Contact
            {
                Name = request.Name,
                Email = request.Email,
                Message= request.Message,
                SendDate = request.SendDate,
                Subject = request.Subject,
            });
        }
    }
}
