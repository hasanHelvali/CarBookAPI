using CarBookAPI.Application.Interfaces ;
using CarBookAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.About.CreateAbout
{
    public class CreateAboutCommandHandler
    {
        private readonly IRepository<Domain.Entities.About> _repository;

        public CreateAboutCommandHandler(IRepository<Domain.Entities.About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutCommandRequest request)
        {
            await _repository.CreateAsync(new Domain.Entities.About
            {
                Title = request.Title,
                Description = request.Description,
                ImageUrl = request.ImageUrl,
            });
        }
    }
}
