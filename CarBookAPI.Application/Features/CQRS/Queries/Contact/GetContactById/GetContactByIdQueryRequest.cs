using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Contact.GetContactById
{
    public class GetContactByIdQueryRequest
    {
        public int ID { get; set; }

        public GetContactByIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}
