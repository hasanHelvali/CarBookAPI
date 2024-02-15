using CarBookAPI.Application.Features.Mediator.Commands.Location.CreateLocation;
using CarBookAPI.Application.Features.Mediator.Commands.Location.RemoveLocation;
using CarBookAPI.Application.Features.Mediator.Commands.Location.UpdateLocation;
using CarBookAPI.Application.Features.Mediator.Queries.Location.GetLocation;
using CarBookAPI.Application.Features.Mediator.Queries.Location.GetLocationById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LocationsController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> LocationList()
        {
            List<GetLocationQueryResponse> values = await _mediator.Send(new GetLocationQueryRequest());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocation(int id)
        {
            GetLocationByIdQueryResponse value = await _mediator.Send(new GetLocationByIdQueryRequest(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLocation (CreateLocationCommandRequest createLocationCommandRequest)
        {
            await _mediator.Send(createLocationCommandRequest);
            return Ok("Lokasyon Bilgisi Eklendi");
        }


        [HttpPut]
        public async Task<IActionResult> UpdateLocation(UpdateLocationCommandRequest  updateLocationCommandRequest)
        {
            await _mediator.Send(updateLocationCommandRequest);
            return Ok("Lokasyon Bilgisi Güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveLocation(RemoveLocationCommandRequest removeLocationCommandRequest)
        {
            await _mediator.Send(removeLocationCommandRequest);
            return Ok("Lokasyon Bilgisi Silindi");
        }
    }
}
