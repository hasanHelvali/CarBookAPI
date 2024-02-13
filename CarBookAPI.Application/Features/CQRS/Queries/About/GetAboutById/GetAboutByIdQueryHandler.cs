using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarBookAPI.Application.Features.CQRS.Queries.About.GetAboutById
{
    public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<Domain.Entities.About> _repository;

        public GetAboutByIdQueryHandler(IRepository<Domain.Entities.About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdQueryResponse> Handle(GetAboutByIdQueryRequest request)
        {
            var values = await _repository.GetByIdAsync(request.ID);
            return new ()
            {
                AboutId=values.AboutId,
                Description=values.Description,
                ImageUrl = values.ImageUrl,
                Title=values.Title,
            };
        }
    }
}
