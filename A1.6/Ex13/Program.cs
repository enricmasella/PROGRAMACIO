using System.Net;

namespace Ex13
{
    internal class Program
    {
        /// <summary>
        /// Considerem el fitxer Girona lliga23_24_v2.txt que conté resultats del Girona de la temporada
        /// 23/24 en un fitxer CSV.Realitza el mateix exercici que férem als recorreguts sabent que la primera
        /// entrada ens dirà el total de jornades de la lliga.
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader sR = new StreamReader(@"..\..\..\..\FITXERS\Girona lliga23_24_v2.txt");
            string linia;
            int qJornades;
            int resultR, resultG;
            int punts = 0;
            int pGuanyats = 0, pEmpatats = 0, pPerduts = 0;
            int i;

   
            linia = sR.ReadLine();
            qJornades = Convert.ToInt32(linia);

            for (i = 0; i < qJornades; i++)
            {
                linia = sR.ReadLine();
                resultR = Convert.ToInt32(linia);

                linia = sR.ReadLine();
                resultG = Convert.ToInt32(linia);

                if (resultG > resultR)
                {
                    pGuanyats++;
                    punts += 3;
                }
                else if (resultG == resultR)
                {
                    pEmpatats++;
                    punts += 1;
                }
                else
                {
                    pPerduts++;
                }
            }

            sR.Close();

            Console.WriteLine($"El total de punts del Girona en la  temporada es de {punts} ");

        }
    }
}
