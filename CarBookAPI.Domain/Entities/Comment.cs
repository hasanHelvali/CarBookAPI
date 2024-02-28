using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Domain.Entities
{
    public class Comment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description{ get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}

/*Repository Tasarım deseni Veri merkezli uygulamalarda veriye erisim ve yonetimin tek yerden yapılmasını saglayan bir tasarım desenidir.
 Yani CRUD işlemlerinin tamamı tek yerde toplanır ve bunlar tek sınıf ve interface uzerinden yonetilir.Iste bunu saglayan bir tasarım desenidir.
CQRS ve Mediator tasarım desenlerinden farkı sudur:
CQRS ve Medaitor tasarım deselerinde Command ve Query işlemlerini yani CRUD işlemlerini iki ayrı parcaya ayrılmıstı. Bunlar yazma ve okuma parametreleriydi.
Lakin repository dessign pattern da bu yapılmaz. Butun işlemler tek interface ve class uzerinden yonetilir.*/
