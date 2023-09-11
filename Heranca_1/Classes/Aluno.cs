using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_1.Classes
{
    internal class Aluno:Pessoa
    {
        public string Responsavel { get; set; }
        public string Turma { get; set; }
        public string Matricula { get; set; }
    }
}
