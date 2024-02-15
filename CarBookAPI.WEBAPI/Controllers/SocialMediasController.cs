using CarBookAPI.Application.Features.Mediator.Commands.SocialMedia.CreateSocialMedia;
using CarBookAPI.Application.Features.Mediator.Commands.SocialMedia.RemoveSocialMedia;
using CarBookAPI.Application.Features.Mediator.Commands.SocialMedia.UpdateSocialMedia;
using CarBookAPI.Application.Features.Mediator.Queries.Service.GetServiceById;
using CarBookAPI.Application.Features.Mediator.Queries.SocialMedia.GetByIdSocialMedia;
using CarBookAPI.Application.Features.Mediator.Queries.SocialMedia.GetSocialMedia;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediasController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SocialMediasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListSocialMedia()
        {
            List<GetSocialMediaQueryResponse> getSocialMediaQueryResponse = await _mediator.Send(new  GetSocialMediaQueryRequest());
            return Ok(getSocialMediaQueryResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocialMedia(int id)
        {
            GetByIdSocialMediaQueryResponse getByIdSocialMediaQueryResponse= await _mediator.Send(new GetByIdSocialMediaQueryRequest(id));
            return Ok(getByIdSocialMediaQueryResponse);
        }
        [HttpPost]
        public async Task<IActionResult> CreateSocialMedia(CreateSocialMediaCommandRequest createSocialMediaCommandRequest)
        {
             await _mediator.Send(createSocialMediaCommandRequest);
            return Ok("Sosyal Medya Bilgisi Eklendi.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaCommandRequest updateSocialMediaCommandRequest)
        {
            await _mediator.Send(updateSocialMediaCommandRequest);
            return Ok("Sosyal Medya Bilgisi Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveSocialMedia(RemoveSocialMediaCommandRequest removeSocialMediaCommandRequest)
        {
            await _mediator.Send(removeSocialMediaCommandRequest);
            return Ok("Sosyal Medya Bilgisi Silindi.");
        }
    }
}
