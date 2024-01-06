using CityBank.Domain.Funcionario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBank.Infrastructure
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public IList<T> GetAll<T>() where T : class
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(int id) where T : class
        {
            throw new NotImplementedException();
        }

        public void Save<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
