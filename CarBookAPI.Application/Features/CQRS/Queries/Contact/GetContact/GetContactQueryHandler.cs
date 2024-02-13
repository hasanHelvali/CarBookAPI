using CarBookAPI.Application.Features.CQRS.Queries.Contact.GetContact;
using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Contact.GetContact
{
    public class GetContactQueryHandler
    {
        private readonly IRepository<Domain.Entities.Contact> _repository;

        public GetContactQueryHandler(IRepository<Domain.Entities.Contact> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetContactQueryResponse>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetContactQueryResponse
            {
                ContactID = x.ContactID,
                Name = x.Name,
                Message = x.Message,
                Subject = x.Subject,
                SendDate = x.SendDate,
                Email = x.Email
            }).ToList();
        }
    }
}
