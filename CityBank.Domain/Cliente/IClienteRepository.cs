using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBank.Domain.Cliente
{
    public interface IClienteRepository : IRepository
    {
        Cliente ObterClientePorCpf(string cpf);
    }
}
