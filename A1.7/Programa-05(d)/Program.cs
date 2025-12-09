using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_05_d_
{
    internal class Program
    {
        /// <summary>
        /// Donada la mateixa seqüència del fitxer de l’apartat 5c, informar si hi ha algun nombre
        /// perfecte a la seqüència
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "PERFECTES.TXT";
            StreamReader sRNumeros = new StreamReader(FILENAME);

            sRNumeros.ReadLine();

            const string MF = null;
            string linia;
            int valor = 0;
            bool trobat = false;

            linia = sRNumeros.ReadLine();

            while (linia != MF && !trobat)
            {
                valor = Convert.ToInt32(sRNumeros.ReadLine());
                trobat = EsPerfecte(valor);
                
                if (!trobat)
                {
                    linia = sRNumeros.ReadLine();
                }
            }

            if (trobat)
            {
                Console.WriteLine($"S'ha trobat un nombre perfecte {valor}");
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
