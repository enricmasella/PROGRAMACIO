using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_02
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, informar si el primer valor es repeteix. Podem considerar un
        ///número per línia.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "NUMEROS (1).TXT";
            StreamReader sRNumeros = new StreamReader(FILENAME);

            const string MF = null;
            bool trobat = false;
            string linia;
            int valor=0;
            int primerValor = 0;

            linia = sRNumeros.ReadLine();
            primerValor = Convert.ToInt32(linia);
            linia = sRNumeros.ReadLine();
            while (linia != MF && !trobat)
            {
               
                valor = Convert.ToInt32(linia);

                if (valor == primerValor)
                {
                    trobat = true;
                }
                linia = sRNumeros.ReadLine();
            }

            if (trobat)
            {
                Console.WriteLine($"El primer valor - {primerValor} - es repeteix. ");
            }
            else
            {
                Console.WriteLine($"El primer valor - {primerValor} - no es repeteix. ");
            }
            sRNumeros.Close();
        }
    }
}
