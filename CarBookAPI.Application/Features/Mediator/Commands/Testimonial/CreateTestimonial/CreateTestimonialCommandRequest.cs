using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Testimonial.CreateTestimonial
{
    public class CreateTestimonialCommandRequest:IRequest
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}