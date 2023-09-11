using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Heranca_1.ClassesAnimais
{
    internal class Mamiferos
    {
        public DateOnly DataNasci { get; set; }
        public string Raca { get; set; }

        public virtual void Barulho()
        {
            Console.WriteLine(this.Raca +  " Som...");
        }
    
    }
}
