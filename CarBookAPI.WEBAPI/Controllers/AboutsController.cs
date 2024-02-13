using CarBookAPI.Application.Features.CQRS.Commands.About.CreateAbout;
using CarBookAPI.Application.Features.CQRS.Commands.About.RemoveAbout;
using CarBookAPI.Application.Features.CQRS.Commands.About.UpdateAbout;
using CarBookAPI.Application.Features.CQRS.Queries.About.GetAbout;
using CarBookAPI.Application.Features.CQRS.Queries.About.GetAboutById;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly CreateAboutCommandHandler _createAboutCommandHandler;
        private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
        private readonly GetAboutQueryHandler _getAboutQueryHandler;

        private readonly UpdateAboutCommandHandler _updateAboutCommandHandler;
        private readonly RemoveAboutCommandHandler _removeAboutCommandHandler;

        public AboutsController(CreateAboutCommandHandler createAboutCommandHandler,
            GetAboutByIdQueryHandler getAboutByIdQueryHandler,
            GetAboutQueryHandler getAboutQueryHandler,
            UpdateAboutCommandHandler updateAboutCommandHandler,
            RemoveAboutCommandHandler removeAboutCommandHandler)
        {
            _createAboutCommandHandler = createAboutCommandHandler;
            _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
            _getAboutQueryHandler = getAboutQueryHandler;
            _updateAboutCommandHandler = updateAboutCommandHandler;
            _removeAboutCommandHandler = removeAboutCommandHandler;
        }


        [HttpGet]
        public async Task<IActionResult> Aboutlist()
        {
            var values = await _getAboutQueryHandler.Handle();
            return Ok(values);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var value = _getAboutByIdQueryHandler.Handle(new GetAboutByIdQueryRequest(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommandRequest createAboutCommandRequest)
        {
            await _createAboutCommandHandler.Handle(createAboutCommandRequest);
            return Ok("Hakkımda Bilgisi Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommandRequest updateAboutCommandRequest)
        {
            await _updateAboutCommandHandler.Handle(updateAboutCommandRequest);
            return Ok("Hakkımda Bilgisi Güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAbout(int id)
        {
            await _removeAboutCommandHandler.Handle(new RemoveAboutCommandRequest(id));
            return Ok("Hakkımda Bilgisi Silindi.");
        }
    }
}
