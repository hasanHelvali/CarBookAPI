using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Testimonial.CreateTestimonial
{
    public class CreateTestimonialCommandHandler : IRequestHandler<CreateTestimonialCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Testimonial> _repository;

        public CreateTestimonialCommandHandler(IRepository<Domain.Entities.Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Domain.Entities.Testimonial
            {
                Title = request.Title,
                ImageUrl = request.ImageUrl,
                Name = request.Name,
                Comment = request.Comment,
            });
        }
    }
}
