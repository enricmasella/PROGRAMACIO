using static System.Net.Mime.MediaTypeNames;

namespace ex1b
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que informa si tots els números d’un fitxer són positius. La seqüència prové del fitxer de text NUMEROS.TXT
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\FITXERS\";
            StreamReader reader = new StreamReader(path + "NUMEROS.TXT");
            int i = 0;
            string linea = reader.ReadLine();
            bool Positius = true;
            while (linea != null && Positius)
            {
                int num = Convert.ToInt32(linea);
                if (num < 0)
                {
                    Positius = false;
                }
                i++;
                linea = reader.ReadLine();
            }
            reader.Close();
            if (Positius)
            {
                Console.WriteLine("Tots els números són positius.");
            }
            else
            {
                Console.WriteLine("Hi ha algun número negatiu.");
            }
        }
    }
}
