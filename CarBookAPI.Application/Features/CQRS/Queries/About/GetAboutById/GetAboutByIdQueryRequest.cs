using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.About.GetAboutById
{
    public class GetAboutByIdQueryRequest
    {
        public GetAboutByIdQueryRequest(int id)
        {
            ID =id;
        }

        public int ID { get; set; }
    }
}
