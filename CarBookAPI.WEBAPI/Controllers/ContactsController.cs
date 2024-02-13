using CarBookAPI.Application.Features.CQRS.Commands.Contact.CreateContact;
using CarBookAPI.Application.Features.CQRS.Commands.Contact.RemoveContact;
using CarBookAPI.Application.Features.CQRS.Commands.Contact.UpdateContact;
using CarBookAPI.Application.Features.CQRS.Queries.Contact.GetContact;
using CarBookAPI.Application.Features.CQRS.Queries.Contact.GetContactById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly GetContactQueryHandler _getContactQueryHandler;
        private readonly GetContactByIdQueryHandler _getContactByIdQueryHandler;
        private readonly CreateContactCommandHandler _createContactCommandHandler;
        private readonly UpdateContactCommandHandler _updateContactCommandHandler;
        private readonly RemoveContactCommandHandler _removeContactCommandHandler;

        public ContactsController(GetContactQueryHandler getContactQueryHandler,
            GetContactByIdQueryHandler getContactByIdQueryHandler, CreateContactCommandHandler
            createContactCommandHandler, UpdateContactCommandHandler updateContactCommandHandler,
            RemoveContactCommandHandler removeContactCommandHandler)
        {
            _getContactQueryHandler = getContactQueryHandler;
            _getContactByIdQueryHandler = getContactByIdQueryHandler;
            _createContactCommandHandler = createContactCommandHandler;
            _updateContactCommandHandler = updateContactCommandHandler;
            _removeContactCommandHandler = removeContactCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> Contactlist()
        {
            var values = await _getContactQueryHandler.Handle();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var value =await _getContactByIdQueryHandler.Handle(new GetContactByIdQueryRequest(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommandRequest createContactCommandRequest)
        {
            await _createContactCommandHandler.Handle(createContactCommandRequest);
            return Ok("İletişim Bilgisi Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactCommandRequest updateContactCommandRequest)
        {
            await _updateContactCommandHandler.Handle(updateContactCommandRequest);
            return Ok("İletişim Bilgisi Güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveContact(int id)
        {
            await _removeContactCommandHandler.Handle(new RemoveContactCommandRequest(id));
            return Ok("İletişim Bilgisi Silindi.");
        }
    }
}
