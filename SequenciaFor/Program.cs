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

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Entrada (I)ntegral (M)eia: ");
                entrada = Console.ReadLine();

                if (entrada == "I")
                {
                    valor = 100;

                } 
                else if (entrada == "M")
                {

                    valor = 100 / 2;

                }

            }

            for (int i = 1; i <= 20; i++) 
            {
                Console.WriteLine("Entrada (I)ntegral (M)eia: ");
                entrada = Console.ReadLine();

                if (entrada == "I")
                {
                    valor = 150;

                }
                else if (entrada == "M")
                {

                    valor = 150 / 2;

                }
            }

            for (int i = 1; i <= 30; i++)
            {
                Console.WriteLine("Entrada (I)ntegral (M)eia: ");
                entrada = Console.ReadLine();

                if (entrada == "I")
                {
                    valor = 200;

                }
                else if (entrada == "M")
                {

                    valor = 200 / 2;

                }

                _ = valor;
                _ = total;
                total = total + valor;

            }
        }
    }
}
