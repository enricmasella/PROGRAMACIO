namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.Write("digues un numero: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("digues un altre numero: ");
            y = Convert.ToInt32(Console.ReadLine());

            for (int i = x; i <= y; i++) 
            {
                if (i % 7 == 0 )
                    Console.WriteLine(i);
            }
        }
    }
}
