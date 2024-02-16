using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Commands.Testimonial.RemoveTestimonial
{
    public class RemoveTestimonialCommandRequest:IRequest
    {
        public int ID { get; set; }

        public RemoveTestimonialCommandRequest(int id)
        {
            ID = id;
        }
    }
}