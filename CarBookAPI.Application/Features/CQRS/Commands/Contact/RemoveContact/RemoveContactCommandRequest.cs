using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Contact.RemoveContact
{
    public class RemoveContactCommandRequest
    {
        public int ID { get; set; }

        public RemoveContactCommandRequest(int id)
        {
            ID = id;
        }
    }
}
