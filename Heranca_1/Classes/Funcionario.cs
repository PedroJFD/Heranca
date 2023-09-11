using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_1.Classes
{
    internal class Funcionario:Pessoa
    {
        public double Salario { get; set; }
        public string SIAP { get; set; }
        public DateOnly CH { get; set; }
    }
}
