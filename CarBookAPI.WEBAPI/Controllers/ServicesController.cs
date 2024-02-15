using CarBookAPI.Application.Features.Mediator.Commands.Service.CreateService;
using CarBookAPI.Application.Features.Mediator.Commands.Service.RemoveService;
using CarBookAPI.Application.Features.Mediator.Commands.Service.UpdateService;
using CarBookAPI.Application.Features.Mediator.Queries.Service.GetService;
using CarBookAPI.Application.Features.Mediator.Queries.Service.GetServiceById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServicesController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            List<GetServiceQueryResponse> values = await _mediator.Send(new GetServiceQueryRequest());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetService(int id)
        {
            GetServiceByIdQueryResponse value = await _mediator.Send(new GetServiceByIdQueryRequest(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceCommandRequest createServiceCommandRequest)
        {
            await _mediator.Send(createServiceCommandRequest);
            return Ok("Hizmet Türü Bilgisi Eklendi");
        }


        [HttpPut]
        public async Task<IActionResult> UpdateService(UpdateServiceCommandRequest updateServiceCommandRequest)
        {
            await _mediator.Send(updateServiceCommandRequest);
            return Ok("Hizmet Türü Bilgisi Güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveService(RemoveServiceCommandRequest removeServiceCommandRequest)
        {
            await _mediator.Send(removeServiceCommandRequest);
            return Ok("Hizmet Türü Bilgisi Silindi");
        }
    }
}
