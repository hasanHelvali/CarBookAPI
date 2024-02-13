using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Category.GetCategoryById
{
    public class GetCategoryByIdQueryResponse
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
