using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Ola me chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
