namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int max = num;
            int min = num;

            while (num != 0)
            {
                if (num > max) max = num;
                if (num < min) min = num;

                Console.Write("Número: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Máximo: " + max);
            Console.WriteLine("Mínimo: " + min);

        }
    }
}
