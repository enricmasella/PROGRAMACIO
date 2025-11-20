using System;
using System.Drawing;
using System.Globalization;

namespace ex12
{
    internal class Program
    {
        /// <summary>
        /// Considerem el fitxer coordenades2.txt on en la primera línia trobarem la quantitat de
        /// coordenades que té el fitxer i la resta contenen les coordenades de diferents punts amb el següent
        /// format: cada coordenada x a cada línia senar i cada coordenada y a cada línia parell.S'introdueix per
        /// teclat el valor del radi r d'una circumferència.
        /// Un exemple de fitxer amb el format especificat anteriorment:
        /// -2,6 → coordenada x
        /// 3,8 → coordenada y
        /// . . .
        /// El programa ha d'informar per a cada punt si està dins, fora o sobre el perímetre de la circumferència
        /// de radi r i centre (0.0).
        /// Crea i utilitza la funció Distancia que retorna la distància d’un punt a l’eix de coordenades.
        /// public static double Distancia(double x, double y)
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader sR = new StreamReader(@"..\..\..\..\fitxers\coordenades2.txt");
            string linia;
            int qCoords;
            double radi, coordX, coordY, puntEix;

            Console.Write("Introdueix el valor del radi de la circumferencia: ");
            radi = Convert.ToInt32(Console.ReadLine());

            linia = sR.ReadLine();
            qCoords = Convert.ToInt32(linia);

            for (int i = 0; i < qCoords; i++)
            {
                linia = sR.ReadLine();
                coordY = Convert.ToDouble(linia, CultureInfo.InvariantCulture);

                linia = sR.ReadLine();
                coordX = Convert.ToDouble(linia, CultureInfo.InvariantCulture);

                puntEix = Distancia(coordX, coordY);

                if (puntEix < radi)
                {
                    Console.WriteLine($"El punt està dins el perímetre de la circumferència de radi {radi} i centre (0.0).");
                }
                else if (puntEix > radi)
                {
                    Console.WriteLine($"El punt està fora el perímetre de la circumferència de radi {radi} i centre (0.0).");
                }
                else
                {
                    Console.WriteLine($"El punt està sobre el perímetre de la circumferència de radi {radi} i centre (0.0).");
                }

            }

            sR.Close();

        }
        public static double Distancia(double x, double y)
        {
            double dPunt;

            dPunt = Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2));

            return dPunt;
        }
    }
}
