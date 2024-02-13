using CarBookAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  CarBookAPI.Domain.Entities;

namespace CarBookAPI.Application.Features.CQRS.Commands.About.RemoveAbout
{
    public class RemoveAboutCommandHandler
    {
        private readonly IRepository<Domain.Entities.About> _repository;

        public RemoveAboutCommandHandler(IRepository<Domain.Entities.About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAboutCommandRequest request)
        {
            var value=await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);

                
        }
    }
}
