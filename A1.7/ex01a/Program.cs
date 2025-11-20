namespace ex1
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que calcula la suma dels números d’una seqüència. La seqüència prové del fitxer de text NUMEROS.TXT.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\FITXERS\";
            StreamReader reader = new StreamReader(path + "NUMEROS.TXT");
            int sum = 0, i = 0;
            string linea = reader.ReadLine();
            while (linea != null) 
            {
                int num = Convert.ToInt32(linea);
                sum += num;
                i++;
                linea = reader.ReadLine();
            }
            reader.Close();
            Console.WriteLine("La suma és: " + sum);

        }
    }
}
