namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (Console.ReadKey().KeyChar == ' ') 
            {
                for (int i = 5; i < 300; i++)
                {
                    if (i % 4 == 0)
                    {
                        Console.WriteLine(i);
                    }

                    if (i == 20)
                    {
                        Console.ReadKey();

                    }
                }

            } 
          
        }
    }
}
