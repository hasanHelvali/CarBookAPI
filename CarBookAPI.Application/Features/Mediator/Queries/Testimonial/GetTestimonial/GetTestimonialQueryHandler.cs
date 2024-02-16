using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Testimonial.GetTestimonial
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQueryRequest, List<GetTestimonialQueryResponse>>
    {
        private readonly IRepository<Domain.Entities.Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Domain.Entities.Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialQueryResponse>> Handle(GetTestimonialQueryRequest request, CancellationToken cancellationToken)
        {
            var values =  await _repository.GetAllAsync();
            return values.Select(x => new GetTestimonialQueryResponse
            {
                Comment = x.Comment,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                TestimonialID = x.TestimonialID,
                Title = x.Title,
            }).ToList();
        }
    }
}
