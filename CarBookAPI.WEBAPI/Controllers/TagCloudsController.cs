using CarBookAPI.Application.Features.Mediator.Commands.TagCloud.CreateTagCloud;
using CarBookAPI.Application.Features.Mediator.Commands.TagCloud.RemoveTagCloud;
using CarBookAPI.Application.Features.Mediator.Commands.TagCloud.UpdateTagCloud;
using CarBookAPI.Application.Features.Mediator.Queries.TagCloud.GetTagCloud;
using CarBookAPI.Application.Features.Mediator.Queries.TagCloud.GetTagCloudByBlogId;
using CarBookAPI.Application.Features.Mediator.Queries.TagCloud.GetTagCloudById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagCloudsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagCloudsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagCloudList()
        {
            List<GetTagCloudQueryResponse> values = await _mediator.Send(new GetTagCloudQueryRequest());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagCloud(int id)
        {
            GetTagCloudByIdQueryResponse value = await _mediator.Send(new GetTagCloudByIdQueryRequest(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTagCloud(CreateTagCloudCommandRequest createTagCloudCommandRequest)
        {
            await _mediator.Send(createTagCloudCommandRequest);
            return Ok("Etiket Başarıyla Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTagCloud(UpdateTagCloudCommandRequest updateTagCloudCommandRequest)
        {
             await _mediator.Send(updateTagCloudCommandRequest);
            return Ok("Etiket Başarıyla Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveTagCloud(RemoveTagCloudCommandRequest removeTagCloudCommandRequest)
        {
            await _mediator.Send(removeTagCloudCommandRequest);
            return Ok("Etiket Başarıyla Silindi.");
        }

        [HttpGet("GetTagCloudByBlogIdList/{id}")]
        public async Task<IActionResult> GetTagCloudByBlogId(int id)
        {
            var values= await _mediator.Send(new GetTagCloudByBlogIdQueryRequest(id));
            return Ok(values);
        }
    }
}
