using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Brand.GetBrandById
{
    public class GetBrandByIdQueryResponse
    {
        public int BrandID { get; set; }
        public string Name { get; set; }
    }
}
