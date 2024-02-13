using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Category.GetCategory
{
    public class GetCategoryQueryResponse
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
