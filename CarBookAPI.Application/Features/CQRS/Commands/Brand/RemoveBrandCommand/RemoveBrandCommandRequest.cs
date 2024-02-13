using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Brand.RemoveBrandCommand
{
    public class RemoveBrandCommandRequest
    {
        public int ID { get; set; }
        public RemoveBrandCommandRequest(int id)
        {
            this.ID = id;
        }


    }
}
