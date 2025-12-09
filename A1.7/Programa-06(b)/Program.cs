using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_06_b_
{
    internal class Program
    {
        /// <summary>
        /// Escriu la funció public static bool EsPrimer(int n) que retorna true si n és un número
        /// primer i seguidament, reescriu el programa 6a usant la funció
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n;

            Console.Write("Escriu un número positiu enter, per saber si és primer o no: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n <= 1)
            {
                Console.WriteLine($"ERROR");
            }
            else
            {
                if (EsPrimer(n))
                {
                    Console.WriteLine($"{n} ÉS PRIMER ");
                }
                else
                {
                    Console.WriteLine($"{n} NO ÉS PRIMER");
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool EsPrimer(int n)
        {
            int i;
            bool sortida=true;

            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sortida = false;
                }
            }

            return sortida;

        }
    }
}
