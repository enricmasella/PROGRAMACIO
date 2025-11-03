namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("NUMEROS.TXT");
            string linea = sr.ReadLine();
            int num = Convert.ToInt32(linea);

            int max = num;
            int min = num;

            while (linea != null)
            {
                num = Convert.ToInt32(linea);
                if (num == 0) break;

                if (num > max) max = num;
                if (num < min) min = num;

                linea = sr.ReadLine();
            }

            sr.Close();
            Console.WriteLine("Máximo: " + max);
            Console.WriteLine("Mínimo: " + min);

        }
    }
}
