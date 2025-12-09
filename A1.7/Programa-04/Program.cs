using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_04
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demana un número per teclat i mostra la primera posició a on es troba
        ///aquest número en el fitxer NUMEROS.TXT.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "NUMEROS (2).TXT";
            StreamReader sRNumeros = new StreamReader(FILENAME);

            const string MF = null;
            bool trobat = false;
            string linia;
            int valor = 0;
            int numeroUsuari;
            int contadorLinies = 0;

            Console.Write("Escriu un número que vulguis buscar al fitxer: ");
            numeroUsuari = Convert.ToInt32(Console.ReadLine());

            linia = sRNumeros.ReadLine();

            while (linia != MF && !trobat)
            {
                valor = Convert.ToInt32(linia);
                trobat = valor == numeroUsuari;
                contadorLinies++;
                
                if (!trobat)
                {
                    linia = sRNumeros.ReadLine();
                }
            }

            if (trobat)
            {
                Console.WriteLine($"LINIA {contadorLinies} ÉS LA PRIMERA POSICIÓ ON APAREIX EL NÚMERO {numeroUsuari}");
            }
            else
            {
                Console.WriteLine($"-1");
            }
            
            sRNumeros.Close();
        }
    }
}
