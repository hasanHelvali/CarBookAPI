using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Blog.RemoveBlog
{
    public class RemoveBlogCommandHandler : IRequestHandler<RemoveBlogCommandRequest>
    {
        private readonly IRepository<Domain.Entities.Blog> _repository;

        public RemoveBlogCommandHandler(IRepository<Domain.Entities.Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveBlogCommandRequest request, CancellationToken cancellationToken)
        {
            var value =await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);
        }
    }
}
