namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           StreamReader f = new StreamReader("alumnesDAMDAW.txt");

            string linea = f.ReadLine();
            int alex = 0, iker = 0;

            while (linea != null)
            {
                if (linea == "Alex") alex++;
                if (linea == "Iker") iker++;
                linea = f.ReadLine();
            }

            f.Close();

            if (alex > iker)
                Console.WriteLine("Hay más Alex.");
            else if (iker > alex)
                Console.WriteLine("Hay más Iker.");
            else
                Console.WriteLine("Hay los mismos.");

        }
    }
}
