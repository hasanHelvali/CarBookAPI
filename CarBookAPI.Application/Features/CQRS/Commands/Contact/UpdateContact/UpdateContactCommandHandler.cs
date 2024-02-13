using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Contact.UpdateContact
{
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Domain.Entities.Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Domain.Entities.Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCommandRequest request)
        {
            var values = await _repository.GetByIdAsync(request.ContactID);
            values.Name = request.Name;
            values.Email = request.Email;
            values.Message = request.Message;
            values.SendDate = request.SendDate;
            values.Subject = request.Subject;
            await _repository.UpdateAsync(values);

        }
    }
}
