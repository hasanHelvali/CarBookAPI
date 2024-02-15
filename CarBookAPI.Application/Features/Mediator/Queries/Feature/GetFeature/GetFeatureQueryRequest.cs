using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Feature.GetFeature
{
    public class GetFeatureQueryRequest : IRequest<List<GetFeatureQueryResponse>>
    {
    }
}
