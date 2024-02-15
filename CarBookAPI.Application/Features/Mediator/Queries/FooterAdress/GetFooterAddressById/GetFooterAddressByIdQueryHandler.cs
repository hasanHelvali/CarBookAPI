using CarBookAPI.Application.Interfaces;
using CarBookAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.FooterAdress.GetFooterAddressById
{
    public class GetFooterAddressByIdQueryHandler : IRequestHandler<GetFooterAddressByIdQueryRequest, GetFooterAddressByIdQueryResponse>
    {
        private readonly IRepository<Domain.Entities.FooterAddress> _repository;

        public GetFooterAddressByIdQueryHandler(IRepository<FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<GetFooterAddressByIdQueryResponse> Handle(GetFooterAddressByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ID);
            return new()
            {
                FooterAddressId = value.FooterAddressId,
                Description = value.Description,
                Phone = value.Phone,
                Address = value.Address,
                Email = value.Email,
            };
        }
    }
}
