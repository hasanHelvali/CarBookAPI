using CarBookAPI.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.FooterAdress.GetFooterAddress
{
    public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQueryRequest, List<GetFooterAddressQueryResponse>>
    {
        private readonly IRepository<Domain.Entities.FooterAddress> _repository;

        public GetFooterAddressQueryHandler(IRepository<Domain.Entities.FooterAddress> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetFooterAddressQueryResponse>> Handle(GetFooterAddressQueryRequest request, CancellationToken cancellationToken)
        {
            List<Domain.Entities.FooterAddress> response = await _repository.GetAllAsync();
            return response.Select(x => new GetFooterAddressQueryResponse
            {
                FooterAddressId=x.FooterAddressId,
                Address = x.Address,
                Description = x.Description,
                Phone = x.Phone,
                Email = x.Email,
            }).ToList();
        }
    }
}
