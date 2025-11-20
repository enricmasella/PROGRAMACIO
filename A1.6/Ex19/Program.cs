namespace ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

            Console.Write("Introdueix un numero enter: "); num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                    if (j < i)
                    {
                        Console.Write("+");
                    }
                }
                sum += i;
                Console.Write(sum);

                Console.WriteLine();
            }

        }
    }
}
