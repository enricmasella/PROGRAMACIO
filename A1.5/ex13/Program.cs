namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
          StreamReader sr = new StreamReader("bonus.txt");
            string linea = sr.ReadLine();

            int total = 0, bonus = 0, ganancias = 0;
            Random rnd = new Random();

            while (linea != null)
            {
                total++;

                if (linea == "BONUS")
                {
                    bonus++;
                    ganancias += rnd.Next(1, 11);
                }

                linea = sr.ReadLine();
            }

            sr.Close();

            Console.WriteLine("Billetes totales: " + total);
            Console.WriteLine("BONUS: " + bonus);
            Console.WriteLine("Ganancias: " + ganancias);
            Console.WriteLine("Porcentaje ganadores: " + (bonus * 100 / total) + "%");

        }
    }
}
