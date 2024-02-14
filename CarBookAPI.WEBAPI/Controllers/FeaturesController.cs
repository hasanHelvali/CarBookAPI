using CarBookAPI.Application.Features.CQRS.Commands.About.RemoveAbout;
using CarBookAPI.Application.Features.Mediator.Commands.CreateFeature;
using CarBookAPI.Application.Features.Mediator.Commands.RemoveFeature;
using CarBookAPI.Application.Features.Mediator.Commands.UpdateFeature;
using CarBookAPI.Application.Features.Mediator.Queries.GetFeature;
using CarBookAPI.Application.Features.Mediator.Queries.GetFeatureById;
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
        public async Task<IActionResult> FeatureList(GetFeatureQueryRequest getFeatureQueryRequest)
        {
            List<GetFeatureQueryResponse> values = await _mediator.Send(getFeatureQueryRequest);
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeature(GetFeatureByIdQueryRequest getFeatureByIdQueryRequest)
        {
            GetFeatureByIdQueryResponse value = await _mediator.Send(getFeatureByIdQueryRequest);
            return Ok(value);
        }

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
            await _mediator.Send(new RemoveAboutCommandRequest(removeFeatureCommandRequest.ID));
            return Ok("Özellik Bşarıyla Silindi.");
            /*Normalde cogu isteket response nesnelerinin ici bos durumda. Bu durumlarda aslında bu response nesnelerini tanımlamamak 
             daha dogru bir yaklasımdır.  Eger response nesnelerini tanımlamazsak burada oldugu gibi bir islemde yapabiliriz.*/
        }

        //[HttpDelete]
        //public async Task<IActionResult> RemoveFeature(int id)
        //{
        //    await _mediator.Send(new RemoveAboutCommandRequest(id);
        //    return Ok("Özellik Bşarıyla Silindi.");
        //} Seklinde de yazılabilirdi.


    }
}
