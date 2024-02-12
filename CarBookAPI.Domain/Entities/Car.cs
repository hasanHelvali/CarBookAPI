using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }
        public int BrandID { get; set; }
        public Brand Brand{ get; set; }//Her arabanın bir markası olmak zorundadır.
        public string Model  { get; set; }
        public string CoverImageUrl  { get; set; }//Kırpılmıs kücük resim url i 
        public int Km{ get; set; }
        public string Transmission{ get; set; }//Vites Türü
        public byte Seat{ get; set; }//Koltuk Sayisi
        public byte Luggage { get; set; }//Bagaj kapasitesi
        public string Fuel{ get; set; }//Yakıt türü
        public string BigImageUrl{ get; set; }//Buyuk resim
        public List<CarFeature> CarFeatures{ get; set; }//Her arabanın bir ozellik tablosu var.
        public List<CarDescription> CarDescriptions{ get; set; }//Acıklamalar da iliskisel olarak eklenmiştir.
        public List<CarPricing> CarPricings { get; set; }

    }
}
