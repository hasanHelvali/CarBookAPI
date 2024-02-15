using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.Mediator.Commands.Feature.RemoveFeature
{
    public class RemoveFeatureCommandRequest : IRequest
    {
        public int ID { get; set; }

        public RemoveFeatureCommandRequest(int id)
        {
            ID = id;
        }
    }
}
