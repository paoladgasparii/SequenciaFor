using System;
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
            double valor = 0;
            double total = 0;
            string entrada;
            double inteira = 0;
            double meia = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Entrada (I)ntegral (M)eia: ");
                entrada = Console.ReadLine();

                if (entrada == "I")
                {
                    valor = 100;
                    inteira++;

                } 
                else if (entrada == "M")
                {

                    valor = valor / 2;
                    meia++;
                }

            }

            for (int i = 1; i <= 20; i++) 
            {
                Console.WriteLine("Entrada (I)ntegral (M)eia: ");
                entrada = Console.ReadLine();

                if (entrada == "I")
                {
                    valor = 150;
                    inteira++;
                }
                else if (entrada == "M")
                {

                    valor = valor / 2;
                    meia++;
                }
            }

            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Entrada (I)ntegral (M)eia: ");
                entrada = Console.ReadLine();

                if (entrada == "I")
                {
                    valor = 200;
                    inteira++;
                }
                else if (entrada == "M")
                {

                    valor = valor / 2;
                    meia++;
                }


                valor++;
                total++;
                total = total + valor;


            }

            Console.WriteLine("Faturamento total: " + total);
            Console.WriteLine("Ingressos pagos integralmente: " +inteira);
            Console.WriteLine("Ingressos pagos meia entrada: " +meia);
        }
    }
}
