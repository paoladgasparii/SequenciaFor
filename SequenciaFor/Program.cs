using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double inteira = 0;
            double meia = 0;

            for (int ingresso = 1; ingresso <= 30; ingresso++)
            {
                double valor = 0;

                if (ingresso <= 10)
                    valor = 100;

                else if (ingresso <= 20)
                    valor = 150;

                else
                    valor = 200;

                Console.WriteLine("Ingresso", +ingresso, ": " );
                Console.WriteLine("Digite (M) se o cliente for Estudante ou (I) caso contrário: ");
                string resp = Console.ReadLine();

                if (resp == "I")
                {
                    total += valor;
                    inteira++;
                }
                else
                {
                    total += valor / 2;
                    meia++;
                }

            }

            Console.WriteLine("Faturamento total: R$" + total);
            Console.WriteLine("Quantidades de entradas integrais: " + inteira);
            Console.WriteLine("Quantidades de meias entradas: " + meia);

            Console.ReadKey();
        }
    }
}
