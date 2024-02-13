using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBookAPI.Domain.Entities;

namespace CarBookAPI.Application.Features.CQRS.Commands.About.UpdateAbout
{
    public class UpdateAboutCommandHandler
    {
        private readonly IRepository<Domain.Entities.About> _repository;

        public UpdateAboutCommandHandler(IRepository<Domain.Entities.About> repository)
        {
            this._repository = repository;
        }
        public async Task Handle(UpdateAboutCommandRequest request)
        {
            var values = await _repository.GetByIdAsync(request.AboutId);
            values.Description = request.Description;
            values.Title = request.Title;
            values.ImageUrl = request.ImageUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
