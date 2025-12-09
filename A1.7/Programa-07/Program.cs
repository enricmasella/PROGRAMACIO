using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Programa_07
{
    internal class Program
    {
        /// <summary>
        /// En una cursa de MTB (Mountain Bike), l’organització es pregunta si el ciclista amb el dorsal 231
        ///s’ha perdut.Donada una seqüència de dorsals d’un fitxer que indica els ciclistes que arriben a la
        ///meta, en ordre d’arribada,
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "PERDUT.TXT";
            StreamReader sRNumeros = new StreamReader(FILENAME);

            const string MF = null;
            string linia;
            int valor;
            int contadorPosicio = 0;
            bool trobat = false;

            linia = sRNumeros.ReadLine();

            while (linia != MF && !trobat)
            {
                contadorPosicio++;
                valor = Convert.ToInt32(linia);
                trobat = valor == 231;
                if (!trobat)
                {
                    linia = sRNumeros.ReadLine();
                }
            }
            sRNumeros.Close();

            if (trobat)
            {
                Console.WriteLine($"EL CICLISTA 231 HA ARRIBAT, I EN POSICIÓ: {contadorPosicio}");
            }
            else
            {
                Console.WriteLine($"EL CICLISTA 231 S'HA PERDUT. ");
            }

        }
    }
}
