using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.SocialMedia.RemoveSocialMedia
{
    public class RemoveSocialMediaCommandHandler : IRequestHandler<RemoveSocialMediaCommandRequest>
    {
        private readonly IRepository<Domain.Entities.SocialMedia> _repository;

        public RemoveSocialMediaCommandHandler(IRepository<Domain.Entities.SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveSocialMediaCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);    
        }
    }
}
