namespace ex1c
{
    internal class Program
    {
        /// <summary>
        ///  Fes un programa que mostra el valor més gran que hi ha en una seqüència de números. La seqüència prové del fitxer de text NUMEROS.TXT.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\FITXERS\";
            StreamReader reader = new StreamReader(path + "NUMEROS.TXT");
            int i = 0;
            string linea = reader.ReadLine();
            int max = Convert.ToInt32(linea);
            while (linea != null)
            {
                int num = Convert.ToInt32(linea);
                if (num > max)
                {
                    max = num;
                }
                i++;
                linea = reader.ReadLine();
            }
            reader.Close();
            Console.WriteLine("El valor més gran és: " + max);
        }
    }
}
