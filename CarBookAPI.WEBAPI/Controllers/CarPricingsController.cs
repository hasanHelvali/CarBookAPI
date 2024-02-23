using CarBookAPI.Application.Features.Mediator.Queries.Car.GetCarWithPricing;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet()]
        public async Task<IActionResult> GetCarsWithPricingList()
        {
            List<GetCarWithPricingQueryResponse> getCarWithPricingQueryResponses = await _mediator.Send(new GetCarWithPricingQueryRequest());
            return Ok(getCarWithPricingQueryResponses);
        }
    }
}
