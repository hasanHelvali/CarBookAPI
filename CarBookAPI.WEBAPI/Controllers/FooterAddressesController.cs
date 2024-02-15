using CarBookAPI.Application.Features.Mediator.Commands.Feature.CreateFeature;
using CarBookAPI.Application.Features.Mediator.Commands.FooterAddress.CreateFooterAddress;
using CarBookAPI.Application.Features.Mediator.Commands.FooterAddress.RemoveFooterAddress;
using CarBookAPI.Application.Features.Mediator.Commands.FooterAddress.UpdateFooterAddress;
using CarBookAPI.Application.Features.Mediator.Queries.FooterAdress.GetFooterAddress;
using CarBookAPI.Application.Features.Mediator.Queries.FooterAdress.GetFooterAddressById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooterAddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListFooterAddress()
        {
            List<GetFooterAddressQueryResponse> getFooterAddressQueryResponse = await _mediator.Send(new GetFooterAddressQueryRequest());
            return Ok(getFooterAddressQueryResponse);
        }
        //[HttpGet]
        //public async Task<IActionResult> ListFooterAddress([FromQuery]GetFooterAddressQueryRequest getFooterAddressQueryRequest)
        //{
        //    List<GetFooterAddressQueryResponse> getFooterAddressQueryResponse = await _mediator.Send(getFooterAddressQueryRequest);
        //    return Ok(getFooterAddressQueryResponse);
        //} V2

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterAddress(int id)
        {
            GetFooterAddressByIdQueryResponse getFooterAddressByIdQueryResponse = await _mediator.Send(new GetFooterAddressByIdQueryRequest(id));
            return Ok(getFooterAddressByIdQueryResponse);
        }

        //[HttpGet("{ID}")]
        //public async Task<IActionResult> GetFooterAddress([FromRoute]GetFooterAddressByIdQueryRequest getFooterAddressByIdQueryRequest)
        //{
        //    GetFooterAddressByIdQueryResponse getFooterAddressByIdQueryResponse = await _mediator.Send(getFooterAddressByIdQueryRequest);
        //    return Ok(getFooterAddressByIdQueryResponse);
        //} //Eger GetFooterAddressByIdQueryRequest sınıfındaki encapsule yapıyı silersek bu sekilde de bir kullanım yapabiliriz.

        [HttpPost]
        public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressCommandRequest createFooterAddressCommandRequest)
        {
            await _mediator.Send(createFooterAddressCommandRequest);
            return Ok("Alt Adres Bilgisi Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressCommandRequest updateFooterAddressCommandRequest)
        {
            await _mediator.Send(updateFooterAddressCommandRequest);
            return Ok("Alt Adres Bilgisi Güncellendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveFooterAddress(RemoveFooterAddressCommandRequest removeFooterAddressCommandRequest)
        {
            await _mediator.Send(removeFooterAddressCommandRequest);
            return Ok("Alt Adres Bilgisi Silindi.");
        }
    }
}
