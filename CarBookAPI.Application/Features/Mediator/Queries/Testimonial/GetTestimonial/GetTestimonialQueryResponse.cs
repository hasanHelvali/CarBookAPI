﻿namespace CarBookAPI.Application.Features.Mediator.Queries.Testimonial.GetTestimonial
{
    public class GetTestimonialQueryResponse
    {
        public int TestimonialID { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}