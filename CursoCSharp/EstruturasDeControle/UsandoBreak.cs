﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class UsandoBreak
    {   
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("O numero que queremos eh: {0}.", numero);
            for(int i = 0; i <= 50; i++) {
                Console.WriteLine("{0} eh o numero que queremos? ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim");
                    break;
                } else
                {
                    Console.WriteLine("Nao");
                }
            }
        }
    }
}
