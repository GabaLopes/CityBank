using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBank.Domain.Cliente
{
    public class Cliente
    {
        public Cliente()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public IList<Conta> Contas { get; set; }
    }
}
