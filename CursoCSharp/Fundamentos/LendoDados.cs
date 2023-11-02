using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual eh o seu nome");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Qual eh a sua idade");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual eh o seu salario");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
