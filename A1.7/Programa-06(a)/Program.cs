using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_06_a_
{
    internal class Program
    {
        /// <summary>
        /// Donat un valor enter positiu introduït pel teclat, indicar si és primer o no.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numeroUsuari, i;
            bool esPrimer = true;

            Console.Write("Escriu un valor enter positiu, per saber si és primer o no: ");
            numeroUsuari = Convert.ToInt32(Console.ReadLine());

            if (numeroUsuari <= 1)
            {
                esPrimer = false;
            }
            else
            {   i = 2;
                while(i  <= numeroUsuari / 2 && esPrimer )
                {
                    if (numeroUsuari % i == 0)
                    {
                        esPrimer = false;
                    }
                    else i++;
                }
            }

            if (esPrimer)
            {
                Console.WriteLine($"{numeroUsuari} ÉS PRIMER ");
            }
            else
            {
                Console.WriteLine($"{numeroUsuari} NO ÉS PRIMER");
            }
        }
    }
}
