using CarBookAPI.Application.Features.Mediator.Commands.Pricing.CreatePricing;
using CarBookAPI.Application.Features.Mediator.Commands.Pricing.RemovePricing;
using CarBookAPI.Application.Features.Mediator.Commands.Pricing.UpdatePricing;
using CarBookAPI.Application.Features.Mediator.Queries.Pricing.GetPricing;
using CarBookAPI.Application.Features.Mediator.Queries.Pricing.GetPricingById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PricingsController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> PricingList()
        {
            List<GetPricingQueryResponse> values = await _mediator.Send(new GetPricingQueryRequest());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPricing(int id)
        {
            GetPricingByIdQueryResponse value = await _mediator.Send(new GetPricingByIdQueryRequest(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreatePricing(CreatePricingCommandRequest createPricingCommandRequest)
        {
            await _mediator.Send(createPricingCommandRequest);
            return Ok("Ödeme Türü Bilgisi Eklendi");
        }


        [HttpPut]
        public async Task<IActionResult> UpdatePricing(UpdatePricingCommandRequest updatePricingCommandRequest)
        {
            await _mediator.Send(updatePricingCommandRequest);
            return Ok("Ödeme Türü Bilgisi Güncellendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemovePricing(RemovePricingCommandRequest removePricingCommandRequest)
        {
            await _mediator.Send(removePricingCommandRequest);
            return Ok("Ödeme Türü Bilgisi Silindi");
        }
    }
}
