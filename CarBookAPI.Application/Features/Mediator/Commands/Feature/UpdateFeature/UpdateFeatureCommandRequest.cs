using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Feature.UpdateFeature
{
    public class UpdateFeatureCommandRequest : IRequest<UpdateFeatureCommandResponse>
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
    }
}
