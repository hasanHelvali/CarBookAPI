using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Author.RemoveAuthor
{
    public class RemoveAuthorCommandHandler : IRequestHandler<RemoveAuthorCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Author> _repository;

        public RemoveAuthorCommandHandler(IRepository<Domain.Entities.Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);
        }
    }
}
