using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ex11
{
    internal class Program
    {
        /// <summary>
        /// Considerem el fitxer BONUS3.TXT per al càlcul del BONUS. La primera línia del fitxer conté el
        /// nombre total de bitllets.Cada línia només informa de si el bitllet té un "BONUS" o no. Si la línia té un
        /// "BONUS", la següent línia contindrà el valor "BONUS", i en cas contrari, "NO BONUS". Fes un
        /// programa que processi un fitxer de dades que contingui línies de “BONUS/NO BONUS” en el format
        /// indicat i informi de quants bonus s'han distribuït, quants bitllets hi apareixen en el fitxer i quin
        /// percentatge de bitllets guanyadors hi ha respecte al total.Ha d’indicar també quin és el guanyat
        /// obtingut amb els bonus trobats al fitxer.
        /// </summary>
        static void Main(string[] args)
        {
            StreamReader sR = new StreamReader(@"..\..\..\..\fitxers\BONUS3.TXT");
            string linia;
            int valorBonus, numBonus = 0, percentatgeBonus, guanyat = 0;
            int totalBitllets;
            int i;

            linia = sR.ReadLine();
            totalBitllets = Convert.ToInt32(linia);

            for (i = 0; i < totalBitllets; i++)
            {
                linia = sR.ReadLine();

                if (linia == "BONUS")
                {
                    valorBonus = Convert.ToInt32(sR.ReadLine());
                    guanyat += valorBonus;
                    numBonus++;
                }

            }

            sR.Close();

            percentatgeBonus = numBonus * 100 / totalBitllets;

            Console.WriteLine($"El guanyat obtingut amb els bonus es de {guanyat}");

        }
    }
}
