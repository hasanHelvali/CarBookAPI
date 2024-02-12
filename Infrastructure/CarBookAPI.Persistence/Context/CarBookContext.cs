using CarBookAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Migration işlemleri icin tane pakete ihtiyacımız var. Bu paketler
 * Microsoft.EntityFrameworkCore
 * Microsoft.EntityFrameworkCore.Design
 * Microsoft.EntityFrameworkCore.SqlServer
 * Microsoft.EntityFrameworkCore.Tools
 seklindedir. Bunlar Migration database vs islemleri icin gereklidir.
Ayrıca persistence projesi Domain projesini refere etti. Cunku  buradaki entity leri dbset olarak kullanmak istiyoruz.
 */
namespace CarBookAPI.Persistence.Context
{
    public class CarBookContext:DbContext
    {
        public DbSet<About> Abouts{ get; set; }
        public DbSet<Banner> Banners{ get; set; }
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Car> Cars{ get; set; }
        public DbSet<CarDescription> CarDescriptions{ get; set; }
        public DbSet<CarFeature> CarFeatures{ get; set; }
        public DbSet<CarPricing> CarPricings{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<Feature> Features{ get; set; }
        public DbSet<FooterAddress> FooterAddresses{ get; set; }
        public DbSet<Location> Locations{ get; set; }
        public DbSet<Pricing> Pricings{ get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<SocialMedia> SocialMedias{ get; set; }
        public DbSet<Testimonial> Testimonials{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CarBookDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
