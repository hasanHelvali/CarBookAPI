using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Queries.Category.GetCategoryById
{
    public class GetCategoryByIdQueryRequest
    {
        public int ID { get; set; }

        public GetCategoryByIdQueryRequest(int id)
        {
            ID = id;
        }
    }
}
