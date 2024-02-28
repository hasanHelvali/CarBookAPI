using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookAPI.Application.Features.GenericRepository
{
    /*Interface ler normalde interface klasorunde tanımlanırdı lakin biz tasarım desenlerini gruplamak adında 
     Repository Dessign Pattern yapılarını da features icine tasıdık.*/
    public interface IGenericRepository<T>where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Remove(T entity);

        //Bu kısmın repository class ı persistance daki commentrepository klasorundedir.
    }

}
