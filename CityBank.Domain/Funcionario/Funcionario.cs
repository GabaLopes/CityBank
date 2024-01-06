using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBank.Domain.Funcionario
{
    public class Funcionario
    {
        public Funcionario()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }

    }
}
