using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.TagCloud.CreateTagCloud
{
    public class CreateTagCloudCommandHandler : IRequestHandler<CreateTagCloudCommandRequest>
    {
        private readonly IRepository<Domain.Entities.TagCloud> _repository;

        public CreateTagCloudCommandHandler(IRepository<Domain.Entities.TagCloud> reposştory)
        {
            _repository = reposştory;
        }

        public async Task Handle(CreateTagCloudCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Domain.Entities.TagCloud
            {
                Title = request.Title,
                BlogId = request.BlogID,
            });
        }
    }
}
