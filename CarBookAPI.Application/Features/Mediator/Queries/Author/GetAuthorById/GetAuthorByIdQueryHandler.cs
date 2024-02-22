using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Author.GetAuthorById
{
    public class GetAuthorByIdQueryHandler : IRequestHandler<GetAuthorByIdQueryRequest, GetAuthorByIdQueryResponse>
    {
        private readonly IRepository<Domain.Entities.Author> _repository;

        public GetAuthorByIdQueryHandler(IRepository<Domain.Entities.Author> repository)
        {
            _repository = repository;
        }

        public async Task<GetAuthorByIdQueryResponse> Handle(GetAuthorByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var value =  await _repository.GetByIdAsync(request.ID);
            return new GetAuthorByIdQueryResponse
            {
                AuthorID = value.ID,
                Description= value.Description,
                ImageUrl= value.ImageUrl,
                Name= value.Name,
            };
        }
    }
}
