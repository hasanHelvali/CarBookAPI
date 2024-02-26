using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.TagCloud.RemoveTagCloud
{
    public class RemoveTagCloudCommandHandler : IRequestHandler<RemoveTagCloudCommandRequest>
    {
        private readonly IRepository<Domain.Entities.TagCloud> _repository;

        public RemoveTagCloudCommandHandler(IRepository<Domain.Entities.TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveTagCloudCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);
        }
    }
}
