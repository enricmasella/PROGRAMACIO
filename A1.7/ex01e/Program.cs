using static System.Net.Mime.MediaTypeNames;

namespace ex1e
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que informa sobre quantes vegades apareix el número 17 en una seqüència de números.La seqüència prové del fitxer de text NUMEROS.TXT.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
           string path = @"..\..\..\..\FITXERS\";
            StreamReader reader = new StreamReader(path + "NUMEROS.TXT");
            int i = 0;
            string linea = reader.ReadLine();
            int count = 0;
            while (linea != null)
            {
                int num = Convert.ToInt32(linea);
                if (num == 17)
                {
                    count++;
                }
                i++;
                linea = reader.ReadLine();
            }
            reader.Close(); 
            Console.WriteLine("El número 17 apareix " + count + " vegades.");


        }
    }
}
