using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureId { get; set; }//Car ve Feature sınıflarını iliskisel olarak bu sınıfta birlesitiriyoruz.
        public int CarId { get; set; }
        public Car Car{ get; set; }
        public Feature Feature{ get; set; }
        public bool Available{ get; set; }
    }
}
