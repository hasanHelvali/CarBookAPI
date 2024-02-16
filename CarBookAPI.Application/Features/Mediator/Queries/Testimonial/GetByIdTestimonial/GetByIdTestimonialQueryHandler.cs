using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Testimonial.GetByIdTestimonial
{
    public class GetByIdTestimonialQueryHandler : IRequestHandler<GetByIdTestimonialQueryRequest, GetByIdTestimonialQueryResponse>
    {
        private readonly IRepository<Domain.Entities.Testimonial> _repository;

        public GetByIdTestimonialQueryHandler(IRepository<Domain.Entities.Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<GetByIdTestimonialQueryResponse> Handle(GetByIdTestimonialQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            return new GetByIdTestimonialQueryResponse
            {
                Title = value.Title,
                Comment = value.Comment,
                ImageUrl = value.ImageUrl,
                Name = value.Name,
                TestimonialID = value.TestimonialID,
            };
        }
    }
}
