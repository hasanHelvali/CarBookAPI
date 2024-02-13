using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.About.GetAbout
{
    public class GetAboutQueryHandler
    {
        private readonly IRepository<Domain.Entities.About> _repository;

        public GetAboutQueryHandler(IRepository<Domain.Entities.About> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAboutQueryResponse>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutQueryResponse
            {
                AboutId = x.AboutId,
                Title = x.Title,
                Description = x.Description,
                ImageUrl = x.ImageUrl
            }).ToList();
        }
    }
}
