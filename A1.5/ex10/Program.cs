namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int unos = 0, seises = 0;
            int tiradas = 0;

            while (unos != seises || tiradas == 0)
            {
                int dado = rnd.Next(1, 7);
                tiradas++;

                if (dado == 1) unos++;
                if (dado == 6) seises++;
            }

            Console.WriteLine("Tiradas: " + tiradas);
            Console.WriteLine("Total de 6: " + seises);

        }
    }
}
