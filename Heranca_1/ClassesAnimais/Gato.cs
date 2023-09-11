using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca_1.ClassesAnimais
{
    internal class Gato:Mamiferos
    {
        public string CorOlhos { get; set; }

        public override void Barulho()
        {
            Console.WriteLine("Miauau!");
        }
    }
}
