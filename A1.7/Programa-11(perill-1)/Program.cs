using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_11_perill_1_
{
    internal class Program
    {
        /// <summary>
        /// Al riu Ebre sospitem que el peix Silur (Silurus glanis) està en perill d’extinció.
        /// Considerarem que el Silur està en perill si en algun tram hi ha 0 silurs
        /// o bé si la suma total de silurs en tots els trams és menor que 10.
        /// Es demana llegir les dades d’un fitxer i informar si està en perill o no.
        /// (Fitxers NOPERILL.TXT, PERILL1.TXT i PERILL2.TXT)
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const string FILENAME = "PERILL1.TXT";
            ComprovaPerill(FILENAME);
        }
        /// <summary>
        /// Aquesta funció comprova si el Silur està en perill d’extinció segons les dades d’un fitxer.
        /// Està en perill si algun tram té 0 silurs o la suma total és menor que 10.
        /// </summary>
        /// <param name="fitxer">Nom del fitxer a llegir</param>
        public static void ComprovaPerill(string fitxer)
        {
            StreamReader srSilurs = new StreamReader(fitxer);
            string linia;
            linia = srSilurs.ReadLine();
            int silurs, suma;
            silurs = 0;
            suma = 0;
            bool perill;
            perill = false;
            
            while (linia != null)
            {
                silurs = Convert.ToInt32(linia);
                if (silurs == 0)
                    perill = true;

                suma = suma + silurs;
                linia = srSilurs.ReadLine();
            }
            
            srSilurs.Close();
            if (perill || suma < 10)
                Console.WriteLine("PERILL D'EXTINCIÓ");
            else
                Console.WriteLine("NO ESTÀ EN PERILL D'EXTINCIÓ");
        }
    }
}
