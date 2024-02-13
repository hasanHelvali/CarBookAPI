using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Category.UpdateCategory
{
    public class UpdateCategoryCommandRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
