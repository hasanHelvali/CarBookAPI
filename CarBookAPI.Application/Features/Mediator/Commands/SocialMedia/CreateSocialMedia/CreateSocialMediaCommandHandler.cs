using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.SocialMedia.CreateSocialMedia
{
    public class CreateSocialMediaCommandHandler : IRequestHandler<CreateSocialMediaCommandRequest>
    {
        private readonly IRepository<Domain.Entities.SocialMedia> _repository;

        public CreateSocialMediaCommandHandler(IRepository<Domain.Entities.SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateSocialMediaCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Domain.Entities.SocialMedia
            {
                Url = request.Url,
                Name = request.Name,
                Icon = request.Icon,
            });
        }
    }
}
