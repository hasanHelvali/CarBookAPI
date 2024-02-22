using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Author.CreateAuthor
{
    public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Author> _repository;

        public CreateAuthorCommandHandler(IRepository<Domain.Entities.Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Domain.Entities.Author
            {
                Description= request.Description,
                ImageUrl=request.ImageUrl,
                Name= request.Name,
            });
        }
    }
}
