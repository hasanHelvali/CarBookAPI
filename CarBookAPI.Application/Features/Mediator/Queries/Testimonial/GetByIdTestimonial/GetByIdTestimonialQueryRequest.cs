using MediatR;

namespace CarBookAPI.Application.Features.Mediator.Queries.Testimonial.GetByIdTestimonial
{
    public class GetByIdTestimonialQueryRequest:IRequest<GetByIdTestimonialQueryResponse>
    {
        public int ID { get; set; }

        public GetByIdTestimonialQueryRequest(int id)
        {
            ID = id;
        }
    }
}