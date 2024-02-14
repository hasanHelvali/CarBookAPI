using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.GetFeatureById
{
    public class GetFeatureByIdQueryRequest:IRequest<GetFeatureByIdQueryResponse>
    {
        public int ID { get; set; }

        public GetFeatureByIdQueryRequest(int id)
        {
            ID = id;
        }

    }
}
