using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.SocialMedia.UpdateSocialMedia
{
    public class UpdateSocialMediaCommandHandler : IRequestHandler<UpdateSocialMediaCommandRequest>
    {
        private readonly IRepository<Domain.Entities.SocialMedia> _repository;

        public UpdateSocialMediaCommandHandler(IRepository<Domain.Entities.SocialMedia> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSocialMediaCommandRequest request, CancellationToken cancellationToken)
        {
            var value =await _repository.GetByIdAsync(request.SocialMediaID);
            value.Url= request.Url;
            value.Icon= request.Icon;
            value.Name= request.Name;
            await _repository.UpdateAsync(value);    
        }
    }
}
