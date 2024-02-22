using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Author.GetAuthor
{
    public class GetAuthorQueryHandler : IRequestHandler<GetAuthorQueryRequest, List<GetAuthorQueryResponse>>
    {
        private readonly IRepository<Domain.Entities.Author> _repository;

        public GetAuthorQueryHandler(IRepository<Domain.Entities.Author> repository)
        {
            this._repository = repository;
        }

        public async Task<List<GetAuthorQueryResponse>> Handle(GetAuthorQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAuthorQueryResponse
            {
                Description = x.Description,
                AuthorID = x.ID,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
            }).ToList();
        }
    }
}
