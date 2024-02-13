using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.About.RemoveAbout
{
    public class RemoveAboutCommandRequest
    {
        public int Id { get; set; }

        public RemoveAboutCommandRequest(int id)
        {
            Id = id;
        }
    }
}
