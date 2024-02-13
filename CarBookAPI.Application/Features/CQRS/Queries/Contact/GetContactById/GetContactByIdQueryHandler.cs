using CarBookAPI.Application.Features.CQRS.Queries.Contact.GetContactById;
using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Contact.GetContactById
{
    public class GetContactByIdQueryHandler
    {
        private readonly IRepository<Domain.Entities.Contact> _repository;

        public GetContactByIdQueryHandler(IRepository<Domain.Entities.Contact> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactByIdQueryResponse> Handle(GetContactByIdQueryRequest request)
        {
            var values = await _repository.GetByIdAsync(request.ID);
            return new GetContactByIdQueryResponse
            {

                ContactID = values.ContactID,
                Name = values.Name,
                Email = values.Email,
                SendDate = values.SendDate,
                Subject = values.Subject,
                Message=values.Message,
            };
        }
    }
}
