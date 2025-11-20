namespace ex1f
{
    internal class Program
    {
        /// <summary>
        ///  Fes un programa que informa si hi ha un número més gran de 17 a una seqüència de números. La seqüència prové del fitxer de text NUMEROS.TXT
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\FITXERS\";
            bool mesGranQue17 = false;
            StreamReader reader = null;

            reader = new StreamReader(path + "NUMEROS.TXT");
            string linea;
            while ((linea = reader.ReadLine()) != null)
            {
                if (int.TryParse(linea, out int num))
                {
                    if (num > 17)
                    {
                        mesGranQue17 = true;
                        break;
                    }
                }
            }
            reader.Close();

            if (mesGranQue17)
            {
                Console.WriteLine("Hi ha almenys un número més gran que 17.");
            }
            else
            {
                Console.WriteLine("No hi ha cap número més gran que 17.");
            }
        }
    }
}
