using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Services
{
    public static class ServiceRegistiration//Registration Sınıfları Static Tanımlanır.
    {
        public static void AddApplicationService(this IServiceCollection collection, IConfiguration configuration)
        {
            collection.AddMediatR(cnfg => cnfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly));
            /*MediatR icin Ctor uyguladıgımız her sınıfta Dependency Injection eklenmis olacak ve her bir sınıf icin tek tek DI
             eklemesi yapmayacaz.*/
        }
        //Bu sınıfı program.cs te cagırıyoruz.
    }
}
