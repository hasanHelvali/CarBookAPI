using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Testimonial.UpdateTestimonial
{
    public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Testimonial> _repository;

        public UpdateTestimonialCommandHandler(IRepository<Domain.Entities.Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTestimonialCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.TestimonialID);
            value.Comment = request.Comment;
            value.Name = request.Name;
            value.ImageUrl = request.ImageUrl;
            value.Title = request.Title;
            await _repository.UpdateAsync(value);
        }
    }
}
