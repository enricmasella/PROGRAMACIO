using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_03
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, indicar si hi ha algun número parell.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "NUMEROS (1).TXT";
            StreamReader sRNumeros = new StreamReader(FILENAME);

            const string MF = null;
            bool trobat= false;
            string linia;
            int valor=0;

            linia = sRNumeros.ReadLine();

            while (linia !=MF && !trobat)
            {
                valor = Convert.ToInt32(linia);

                if (EsParell(valor))
                {
                    trobat = true;
                }
                else
                {
                    linia = sRNumeros.ReadLine();
                }
            }
            
            if (trobat)
            {
                Console.WriteLine($"S'ha trobat un nombre parell: {valor}");
            }
            else
            {
                Console.WriteLine($"No hi ha cap nombre parell. ");
            }


            sRNumeros.Close();
        }
        /// <summary>
        /// Funcion que comprova si un número és parell.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool EsParell(int n)
        {
            return n % 2 == 0;
        }
    }
}
