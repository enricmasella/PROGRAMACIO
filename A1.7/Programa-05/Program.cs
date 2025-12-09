using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_05
{
    internal class Program
    {
        /// <summary>
        /// Es considera que qualsevol nombre enter positiu n és perfecte si la suma dels seus divisors,
        /// excepte ell mateix, és igual a n.Per exemple, 6 és perfecte, ja que 6=1+2+3
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int numeroUsuari;

            Console.Write("Entra un número per saber si és perfecte o no: ");
            numeroUsuari = Convert.ToInt32(Console.ReadLine());

            if (numeroUsuari <= 0)
            {
                Console.WriteLine($"ERROR");
            }
            else
            { 
                if (EsPerfecte(numeroUsuari))
                {
                    Console.WriteLine($"{numeroUsuari} és un nombre perfecte!");
                }
                else
                {
                    Console.WriteLine($"{numeroUsuari} no és un nombre perfecte.");
                }
            }
        }
        /// <summary>
        /// Funcio que analitza el numero entrat per lusuari per saber si és un número perfecte o no.
        /// </summary>
        /// <param name="numeroUsuari"></param>
        /// <returns></returns>
        public static bool EsPerfecte(int numeroUsuari)
        {
            int suma = 0;
            int n = 1;

            while (n < numeroUsuari/2)
            {
                if (numeroUsuari % n == 0)
                {
                    suma = suma + n;
                }
                n++;
            }
            return suma == n;
        }
    }
}
