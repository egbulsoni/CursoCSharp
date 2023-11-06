using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaFor
    {
        public static void Executar()
        {
            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine($"O valor de i eh {i}.");
                i += 2;
            }

            for(int j = 1; j <= 10; j++) {
                Console.WriteLine($"O valor de j eh {j}.");
            }

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for (int j = 1; j <= tamanhoTurma; j++)
            {
                Console.Write("Informe a nota do aluno {0}: ", j);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma: {0}", media);
        }
    }
}
