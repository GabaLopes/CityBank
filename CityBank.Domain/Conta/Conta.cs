using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBank.Domain.Conta
{
    public class Conta
    {
        public Conta()
        {

        }

        public int Id { get; set; }
        public string Numero { get; set; }
        public decimal Saldo { get; set; }
        public TipoConta Tipo { get; set; }
        public Cliente Cliente { get; set; }
    }
}
