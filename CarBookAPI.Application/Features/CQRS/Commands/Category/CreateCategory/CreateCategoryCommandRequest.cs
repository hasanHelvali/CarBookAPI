using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.CQRS.Commands.Category.CreateCategory
{
    public class CreateCategoryCommandRequest
    {
        public string Name { get; set; }
    }
}
