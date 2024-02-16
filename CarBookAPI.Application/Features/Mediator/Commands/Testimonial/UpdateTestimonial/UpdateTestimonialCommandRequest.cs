using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Testimonial.UpdateTestimonial
{
    public class UpdateTestimonialCommandRequest:IRequest
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}