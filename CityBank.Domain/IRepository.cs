using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBank.Domain
{
    public interface IRepository
    {
        void Save<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        T GetById<T>(int id) where T : class;
        IList<T> GetAll<T>() where T : class;
    }
}
