using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ex14
{
    internal class Program
    {
        /// <summary>
        /// donat el fitxer tiquetsuper.txt, calcular la el preu total de la compra del tiquet. La primera línia
        /// del fitxer indica el nombre de productes.Després cada producte està format per tres línies(Nom del
        /// producte, Quantitat comprada de producte, Preu unitari del producte). El programa haurà d’indicar 
        /// preu final del tiquet.
        /// tiquetsuper.txt
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader sR = new StreamReader(@"..\..\..\..\FITXERS\tiquetsuper.txt");
            string linia;
            int nProductes;
            int qProducte;
            double preuProducte, ProducteTotal;
            double preuFinal = 0;
            int i;

            linia = sR.ReadLine();
            nProductes = Convert.ToInt32(linia);
        
            for (i = 0; i < nProductes; i++)
            {
                linia = sR.ReadLine();
                qProducte = Convert.ToInt32(sR.ReadLine());
                preuProducte = Convert.ToDouble(sR.ReadLine());

                ProducteTotal = qProducte * preuProducte;

                preuFinal += ProducteTotal;
            }

            sR.Close();

            Console.WriteLine($"El preu final es {preuFinal}");

        }
    }
}
