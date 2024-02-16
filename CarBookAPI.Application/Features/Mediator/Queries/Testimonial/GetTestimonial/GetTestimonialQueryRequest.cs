using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Testimonial.GetTestimonial
{
    public class GetTestimonialQueryRequest:IRequest<List<GetTestimonialQueryResponse>>
    {
    }
}