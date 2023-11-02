using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            double raio = 5.5;
            const double PI = Math.PI;

            double area = PI * Math.Pow(raio, 2);
            Console.WriteLine("area: " + area);
        }
    }
}
