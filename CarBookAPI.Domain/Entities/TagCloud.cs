using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Domain.Entities
{
    public class TagCloud
    {
        public int ID { get; set; }
        public string Title{ get; set; }
        public int BlogId{ get; set; }//İlgili tag in hangi blog ile iliskili oldugunun tespiti icin bu sekilde id ler kullanırız.
        public Blog Blog{ get; set; }
    }
}
