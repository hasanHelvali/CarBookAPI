using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Category.RemoveCategory
{
    public class RemoveCategoryCommandRequest
    {
        public int ID { get; set; }

        public RemoveCategoryCommandRequest(int id)
        {
            ID = id;
        }
    }
}
