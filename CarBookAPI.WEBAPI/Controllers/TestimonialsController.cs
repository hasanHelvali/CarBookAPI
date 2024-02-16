using CarBookAPI.Application.Features.CQRS.Commands.About.UpdateAbout;
using CarBookAPI.Application.Features.Mediator.Commands.Testimonial.CreateTestimonial;
using CarBookAPI.Application.Features.Mediator.Commands.Testimonial.RemoveTestimonial;
using CarBookAPI.Application.Features.Mediator.Queries.Testimonial.GetByIdTestimonial;
using CarBookAPI.Application.Features.Mediator.Queries.Testimonial.GetTestimonial;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookAPI.WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public TestimonialsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListTestimonials()
        {
            List<GetTestimonialQueryResponse> getTestimonialQueryResponse= await _mediator.Send(new GetTestimonialQueryRequest());
            return Ok(getTestimonialQueryResponse);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            GetByIdTestimonialQueryResponse getByIdTestimonialQueryResponse = await _mediator.Send(new GetByIdTestimonialQueryRequest(id));
            return Ok(getByIdTestimonialQueryResponse);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialCommandRequest createTestimonialCommandRequest)
        {
             await _mediator.Send(createTestimonialCommandRequest);
            return Ok("Referans Başarıyla Eklendi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateAboutCommandRequest updateAboutCommandRequest)
        {
            await _mediator.Send(updateAboutCommandRequest);
            return Ok("Referans Başarıyla Güncellendi.");
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveTestimonia(RemoveTestimonialCommandRequest removeTestimonialCommandRequest)
        {
            await _mediator.Send(removeTestimonialCommandRequest);
            return Ok("Referans Başarıyla Silindi");
        }
    }
}
