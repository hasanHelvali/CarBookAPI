using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Queries.Feature.GetFeatureById
{
    public class GetFeatureByIdQueryResponse
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
    }
}
