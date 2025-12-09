using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_05_c_
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència de valors procedents d’un fitxer, informar per a cada valor, si és
        /// perfecte o no
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "PERFECTES.TXT";
            StreamReader sRNumeros = new StreamReader(FILENAME);
            
            const string MF = null;
            string linia;
            int valor;

            linia = sRNumeros.ReadLine();

            while (linia != MF)
            {
                valor = Convert.ToInt32(linia);
                if (valor <= 0)
                {
                    Console.WriteLine($"ERROR");
                }
                else
                {
                    if (EsPerfecte(valor))
                    {
                        Console.WriteLine($"{valor} és un nombre perfecte!");
                    }
                    else
                    {
                        Console.WriteLine($"{valor} no és un nombre perfecte");
                    }
                }

                linia = sRNumeros.ReadLine();
            }
            sRNumeros.Close();
        }
        /// <summary>
        /// Funcio que analitza el numero entrat per lusuari per saber si és un número perfecte o no.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        public static bool EsPerfecte(int valor)
        {
            int suma = 0;
            int n = 1;

            while (n < valor)
            {
                if (valor % n == 0)
                {
                    suma = suma + n;
                }
                n++;
            }
            return suma == n;
        }
    }
}
