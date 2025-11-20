namespace ex02a
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, informar si el primer valor es repeteix. Podem considerar un número per línia. 7Versió 1: La seqüència prové d’un reader de text que conté com a mínim un número. Usarem el reader NUMEROS.TXT
        /// </summary>
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\FITXERS\";
            StreamReader reader = new StreamReader(path + "NUMEROS.TXT");
            string linia = reader.ReadLine();
            int num = Convert.ToInt32(linia);
            int rep = 0;

            linia = reader.ReadLine();
            while (linia != null)
            {
                int numero = Convert.ToInt32(linia);
                if (numero == num)
                {
                    rep = 1;
                }
                linia = reader.ReadLine();
            }
            reader.Close();

            if (rep == 1)
            {
                Console.WriteLine("El primer valor es repeteix.");
            }
            else
            {
                Console.WriteLine("El primer valor no es repeteix.");
            }
        }
    }
}
