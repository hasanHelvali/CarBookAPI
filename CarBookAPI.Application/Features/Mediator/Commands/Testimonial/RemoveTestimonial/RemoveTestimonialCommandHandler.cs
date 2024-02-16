using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Testimonial.RemoveTestimonial
{

    public class RemoveTestimonialCommandHandler : IRequestHandler<RemoveTestimonialCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Testimonial> _repository;

        public RemoveTestimonialCommandHandler(IRepository<Domain.Entities.Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);
        }
    }
}
