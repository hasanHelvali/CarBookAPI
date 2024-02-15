using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Feature.CreateFeature
{
    public class CreateFeatureCommandRequest : IRequest<CreateFeatureCommandResponse>
    {
        public string Name { get; set; }
    }
}
