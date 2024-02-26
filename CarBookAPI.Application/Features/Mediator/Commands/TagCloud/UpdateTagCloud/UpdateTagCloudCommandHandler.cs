using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.TagCloud.UpdateTagCloud
{
    public class UpdateTagCloudCommandHandler : IRequestHandler<UpdateTagCloudCommandRequest>
    {
        private readonly IRepository<Domain.Entities.TagCloud> _repository;

        public UpdateTagCloudCommandHandler(IRepository<Domain.Entities.TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTagCloudCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            value.Title= request.Title;
            value.BlogId= request.BlogID;
            await _repository.UpdateAsync(value);
        }
    }
}
