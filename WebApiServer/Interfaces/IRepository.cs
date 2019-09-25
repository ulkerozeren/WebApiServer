using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiServer.Interfaces
{
    public interface IRepository<T> where T: class
    {
        List<T> GetAll();
        T GetById(int id);
        T Update(T model);
        T Delete(int id);
        void Add(T model);
    }
}
