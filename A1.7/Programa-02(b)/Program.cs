using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_02_b_
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, informar si el primer valor es repeteix, amb el valors entrats per teclat.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int primerValor;
            int valor = 0;
            int comptadorRepeticions = 0;

            Console.Write("ESCRIU UN NOMBRE ENTER (escriu -9999 per acabar): ");
            primerValor = Convert.ToInt32(Console.ReadLine());
            if (primerValor == -9999)
            {
                Console.WriteLine($"NO HAS ESCRIT CAP NOMBRE. ");
            }
            else
            {
                while (primerValor != -9999 && valor != -9999)
                {
                    if (primerValor != valor)
                    {
                        Console.Write("ESCRIU UN NOMBRE ENTER (escriu -9999 per acabar): ");
                        valor = Convert.ToInt32(Console.ReadLine());
                    }
                    else
                    {
                        comptadorRepeticions++;
                        Console.Write("ESCRIU UN NOMBRE ENTER (escriu -9999 per acabar): ");
                        valor = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine($"EL TEU PRIMER NOMBRE {primerValor} ES REPETEIX {comptadorRepeticions} VEGADA/ES");
            }
        }
    }
}
