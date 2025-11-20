using static System.Net.Mime.MediaTypeNames;

namespace ex1d
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que mostra tots els valors múltiples de dos que hi ha en una seqüència denúmeros.La seqüència prové del fitxer de text NUMEROS.TXT.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           string path = @"..\..\..\..\FITXERS\";
            StreamReader reader = new StreamReader(path + "NUMEROS.TXT");
            int i = 0;
            string linea = reader.ReadLine();
            Console.WriteLine("Els valors múltiples de dos són:");
            while (linea != null)
            {
                int num = Convert.ToInt32(linea);
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                i++;
                linea = reader.ReadLine();
            }
            reader.Close(); 


        }
    }
}
