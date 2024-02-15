using CarBookAPI.Application.Features.CQRS.Commands.About.RemoveAbout;
using CarBookAPI.Application.Features.Mediator.Commands.Feature.CreateFeature;
using CarBookAPI.Application.Features.Mediator.Commands.Feature.RemoveFeature;
using CarBookAPI.Application.Features.Mediator.Commands.Feature.UpdateFeature;
using CarBookAPI.Application.Features.Mediator.Queries.Feature.GetFeature;
using CarBookAPI.Application.Features.Mediator.Queries.Feature.GetFeatureById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> FeatureList([FromQuery]GetFeatureQueryRequest getFeatureQueryRequest)
            /*Eger burada FromQuery yazmazsak istek atamayız cunku Get isteklerinde bir govde gonderilemez.
            Get metotlarının bilgi alabilmesi icin FromRoute ve FromQuery kullanmaları gerekir. Aksı halde bir veri elde edemezler.
            Burada GetFeatureQueryRequest zaten bos yani kullanmasak aslında daha iyi olurdu. Lakin illa kullanmamız gerekirse, 
            iste bu sekilde route veya query den veriler alıp kullanabiliriz...*/
        {
            List<GetFeatureQueryResponse> values = await _mediator.Send(getFeatureQueryRequest);
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeature(int id)
        {
            GetFeatureByIdQueryResponse value = await _mediator.Send(new GetFeatureByIdQueryRequest(id));
            return Ok(value);
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetFeature([FromRoute]GetFeatureByIdQueryRequest getFeatureByIdQueryRequest)
        //{
        //    GetFeatureByIdQueryResponse value = await _mediator.Send(getFeatureByIdQueryRequest);
        //    return Ok(value);
        //}
        /*Bu kod blogu GetFeatureByIdQueryRequest sınıfındaki ID encapsulation i silinirse kullanılabilecek bir kod yapısıdır.   */

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureCommandRequest createFeatureCommandRequest)
        {
            CreateFeatureCommandResponse createFeatureCommandResponse = await _mediator.Send(createFeatureCommandRequest);
            createFeatureCommandResponse.Message = "Ozellik Basarıyla Eklendi.";
            return Ok(createFeatureCommandResponse);
            //return Ok("Ozellik Basarıyla Eklendi."); Geri donus tipi ayarlandıgında bu sekilde bir cıktı da dondurulebilirdi.
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureCommandRequest updateFeatureCommandRequest)
        {
            UpdateFeatureCommandResponse updateFeatureCommandResponse = await _mediator.Send(updateFeatureCommandRequest);
            updateFeatureCommandResponse.Message = "Özellik Başarıyla Güncellendi.";
            return Ok(updateFeatureCommandResponse);
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveFeature(RemoveFeatureCommandRequest removeFeatureCommandRequest)
        {
            //await _mediator.Send(new RemoveFeatureCommandRequest(removeFeatureCommandRequest.ID));
            await _mediator.Send(removeFeatureCommandRequest);
            return Ok("Özellik Bşarıyla Silindi.");
            /*Normalde cogu isteket response nesnelerinin ici bos durumda. Bu durumlarda aslında bu response nesnelerini tanımlamamak 
             daha dogru bir yaklasımdır.  Eger response nesnelerini tanımlamazsak burada oldugu gibi bir islemde yapabiliriz.*/
        }

        //[HttpDelete]
        //public async Task<IActionResult> RemoveFeature(RemoveFeatureCommandRequest removeFeatureCommandRequest)
        //{
        //    await _mediator.Send(new RemoveFeatureCommandRequest(removeFeatureCommandRequest.ID));
        //    return Ok("Özellik Bşarıyla Silindi.");
        //} V2

        //[HttpDelete]
        //public async Task<IActionResult> RemoveFeature(int id)
        //{
        //    await _mediator.Send(new RemoveAboutCommandRequest(id);
        //    return Ok("Özellik Bşarıyla Silindi.");
        //} V3


    }
}
