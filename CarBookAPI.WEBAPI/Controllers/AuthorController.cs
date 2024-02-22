using CarBookAPI.Application.Features.CQRS.Commands.About.CreateAbout;
using CarBookAPI.Application.Features.CQRS.Commands.About.RemoveAbout;
using CarBookAPI.Application.Features.CQRS.Commands.About.UpdateAbout;
using CarBookAPI.Application.Features.Mediator.Commands.Author.CreateAuthor;
using CarBookAPI.Application.Features.Mediator.Commands.Author.RemoveAuthor;
using CarBookAPI.Application.Features.Mediator.Commands.Author.UpdateAuthor;
using CarBookAPI.Application.Features.Mediator.Queries.Author.GetAuthor;
using CarBookAPI.Application.Features.Mediator.Queries.Author.GetAuthorById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> AuthorList()
        {
            List<GetAuthorQueryResponse> getAuthorQueryResponses = await _mediator.Send(new GetAuthorQueryRequest());
            return Ok(getAuthorQueryResponses);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            GetAuthorByIdQueryResponse getAuthorByIdQueryResponse = await _mediator.Send(new GetAuthorByIdQueryRequest(id));
            return Ok(getAuthorByIdQueryResponse);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAuthorCommandRequest createAuthorCommandRequest)
        {
            await _mediator.Send(createAuthorCommandRequest);
            return Ok("Yazar Bilgisi Eklendi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAuthor(UpdateAuthorCommandRequest updateAuthorCommandRequest)
        {
            await _mediator.Send(updateAuthorCommandRequest);
            return Ok("Yazar Bilgisi Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
           await _mediator.Send(new RemoveAuthorCommandRequest(id));
            return Ok("Yazar Bilgisi Silindi");
        }
    }
}
