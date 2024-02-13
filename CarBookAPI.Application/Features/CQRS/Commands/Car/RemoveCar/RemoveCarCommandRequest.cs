using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Car.RemoveCar
{
    public class RemoveCarCommandRequest
    {
        public int ID { get; set; }

        public RemoveCarCommandRequest(int id)
        {
            ID = id;
        }
    }
}
