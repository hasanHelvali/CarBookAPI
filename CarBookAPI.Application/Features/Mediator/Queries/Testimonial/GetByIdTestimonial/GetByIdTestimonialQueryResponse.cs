namespace CarBookAPI.Application.Features.Mediator.Queries.Testimonial.GetByIdTestimonial
{
    public class GetByIdTestimonialQueryResponse
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}