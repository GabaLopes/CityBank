using CityBank.Domain.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBank.Application
{
    public interface IClienteService
    {
        void CadastrarCliente(Cliente cliente);
        void AtualizarCliente(Cliente cliente);
        void ExcluirCliente(Cliente cliente);
        Cliente ObterCliente(int id);
        IList<Cliente> ObterTodosClientes();
    }
}
