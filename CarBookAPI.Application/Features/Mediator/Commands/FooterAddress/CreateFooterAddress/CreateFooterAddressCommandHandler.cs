using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.FooterAddress.CreateFooterAddress
{
    public class CreateFooterAddressCommandHandler : IRequestHandler<CreateFooterAddressCommandRequest>
    {
        private readonly IRepository<Domain.Entities.FooterAddress> _repository;

        public CreateFooterAddressCommandHandler(IRepository<Domain.Entities.FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateFooterAddressCommandRequest request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Domain.Entities.FooterAddress
            {
                Address = request.Address,
                Description = request.Description,
                Email = request.Email,
                Phone = request.Phone
            });
            return;
        }
    }
}
