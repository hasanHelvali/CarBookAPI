using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrandById
{
    public class GetBrandByIdQueryRequest
    {
        public int ID { get; set; }
        public GetBrandByIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}
