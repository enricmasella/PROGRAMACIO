using System.Runtime.ConstrainedExecution;

namespace ex03a
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, indicar si hi ha algun número parell.
        /// Versió 1: La seqüència prové d’un fitxer de text(un enter per línia).
        /// Usarem el fitxer NUMEROS.TXT que conté molts números parells i NUMEROS2.TXT que no conté cap número parell
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\FITXERS\";
            StreamReader reader = new StreamReader(path + "NUMEROS2.TXT" ); // "NUMEROS2.TXT" per provar el cas sense números parells.
            bool hiHaParell = false;
            string linea = reader.ReadLine();
            while (true) { 
                if (linea == null)
                {
                    break;
                }
                int num = Convert.ToInt32(linea);
                if (num % 2 == 0)
                {
                    hiHaParell = true;
                    break;
                }
                linea = reader.ReadLine();
            }
            reader.Close();
            if (hiHaParell)
            {
                Console.WriteLine("Hi ha almenys un número parell.");
            }
            else
            {
                Console.WriteLine("No hi ha cap número parell.");
            }
            

        }
    }
}
