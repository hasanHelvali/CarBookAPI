using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Author.UpdateAuthor
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Author> _repository;

        public UpdateAuthorCommandHandler(IRepository<Domain.Entities.Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAuthorCommandRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.AuthorID);
            value.Description = request.Description;
            value.Name= request.Name;
            value.ImageUrl = request.ImageUrl;
            await _repository.UpdateAsync(value);
        }
    }
}
