using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_10_noPlaga_
{
    internal class Program
    {
        /// <summary>
        /// Tenim les dades del cens de població del musclo zebra (Dreissena Polymorpha) en el riu Ebre.
        /// Les dades es donen per trams (un número per línia) i es considera plaga quan hi ha 5 o més trams consecutius
        /// amb més de 500 exemplars per tram.
        /// Es demana llegir les dades del fitxer i informar si hi ha plaga o no.
        /// (Fitxers PLAGA.TXT i NOPLAGA.TXT)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "NOPLAGA.TXT";
            ComprovaPlaga(FILENAME);
        }
        /// <summary>
        /// Aquesta funció comprova si hi ha plaga de musclo zebra en un fitxer donat.
        /// Hi ha plaga si apareixen 5 o més trams consecutius amb més de 500 exemplars.
        /// </summary>
        /// <param name="fitxer">Nom del fitxer a llegir</param>
        public static void ComprovaPlaga(string fitxer)
        {
            StreamReader srTrams = new StreamReader(fitxer);
            string linia;
            linia = srTrams.ReadLine();

            int exemplars, comptadorConsecutius;
            exemplars = 0;
            comptadorConsecutius = 0;
            bool plaga;
            plaga = false;

            while (linia != null && !plaga)
            {
                exemplars = Convert.ToInt32(linia);

                if (exemplars > 500)
                {
                    comptadorConsecutius++;
                    if (comptadorConsecutius >= 5)
                        plaga = true;
                }
                else
                {
                    comptadorConsecutius = 0;
                }

                linia = srTrams.ReadLine();
            }

            srTrams.Close();

            if (plaga)
                Console.WriteLine("HI HA PLAGA");
            else
                Console.WriteLine("NO HI HA PLAGA");
        }
    }
}
