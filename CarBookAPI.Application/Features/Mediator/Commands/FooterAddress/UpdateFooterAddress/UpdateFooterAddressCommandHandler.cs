using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.FooterAddress.UpdateFooterAddress
{
    public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommandRequest>
    {
        private readonly IRepository<Domain.Entities.FooterAddress> _repository;

        public UpdateFooterAddressCommandHandler(IRepository<Domain.Entities.FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateFooterAddressCommandRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.FooterAddress value = await _repository.GetByIdAsync(request.FooterAddressID);
            value.Address=request.Address;
            value.Phone=request.Phone;
            value.Description=request.Description;
            value.Email=request.Email;
            //value.FooterAddressId = request.FooterAddressID;
            await _repository.UpdateAsync(value);
            return;
        }
    }
}
