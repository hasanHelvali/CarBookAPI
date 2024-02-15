using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.FooterAddress.RemoveFooterAddress
{
    public class RemoveFooterAddressCommandHandler : IRequestHandler<RemoveFooterAddressCommandRequest>
    {
        private readonly IRepository<Domain.Entities.FooterAddress> _repository;

        public RemoveFooterAddressCommandHandler(IRepository<Domain.Entities.FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveFooterAddressCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.FooterAddress value = await _repository.GetByIdAsync(request.ID);
            await _repository.RemoveAsync(value);
            return;
        }
    }
}
