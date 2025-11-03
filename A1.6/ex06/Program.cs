namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zeros = 0;
            int negatius = 0;
            int positius = 0;
            int num;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digues un numero: ");
                num = Convert .ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    zeros++;
                }
                else if (num < 0)
                {
                    negatius++;
                }
                 
                else if (num> 0)
                {
                    positius++;
                }

            }
            Console.WriteLine($"has introduit {positius} numeros positius, {negatius} numeros negatius i {zeros} zeros");

        }
    }
}
