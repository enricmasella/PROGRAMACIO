using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_08_no_compleix_
{
    internal class Program
    {
        /// <summary>
        ///Escriu un programa que llegeixi una seqüència d’enters d’un fitxer i ens informi si es compleix
        ///sempre la condició que l’element llegit és igual a la suma de tots els anteriors que han aparegut.
        ///El resultat del programa és "SÍ" si compleix la condició i "NO" si no la compleix
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "NOCOMPLEIX.TXT";
            StreamReader sRNumeros = new StreamReader(FILENAME);

            const string MF = null;
            string linia;
            int valor;
            int sumaValors = 0;
            bool resultat = true;

            linia = sRNumeros.ReadLine();

            while (linia != MF && resultat)
            {
                valor = Convert.ToInt32(linia);
                sumaValors = sumaValors + valor;

                if (valor != sumaValors)
                {
                    resultat = false;
                }
                else
                {
                    linia = sRNumeros.ReadLine();
                }
            }
            sRNumeros.Close();

            if (resultat)
            {
                Console.WriteLine($"SÍ");
            }
            else
            {
                Console.WriteLine($"NO");
            }
        }
    }
}
