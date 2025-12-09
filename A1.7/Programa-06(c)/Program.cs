using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Programa_06_c_
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència de valors procedents d’un fitxer, informar per a cada valor, si és
        ///primer o no (CERCA O RECORREGUT?) Usar el fitxer ALGUNSPRIMERS.TXT
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "ALGUNSPRIMERS.TXT";
            StreamReader sRNumeros = new StreamReader(FILENAME);

            const string MF = null;
            string linia;
            int valor;

            linia = sRNumeros.ReadLine();

            while (linia != MF)
            {
                valor = Convert.ToInt32(linia);
                if (valor <= 1)
                {
                    Console.WriteLine($"{valor} --> VALORS <=1 NO SÓN PRIMERS");
                }
                else
                {
                    if (EsPrimer(valor))
                    {
                        Console.WriteLine($"{valor} ÉS PRIMER ");
                    }
                    else
                    {
                        Console.WriteLine($"{valor} NO ÉS PRIMER");
                    }
                }
                linia = sRNumeros.ReadLine();
            }
            sRNumeros.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool EsPrimer(int valor)
        {
            int i = 2;
            bool sortida = true;

            while (sortida && i < (valor / 2))
            {
                if (valor % i == 0)
                {
                    sortida = false;
                }
                else
                {
                    i++;
                }
            }
            return sortida;
        }
    }
}
