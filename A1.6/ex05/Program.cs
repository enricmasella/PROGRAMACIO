namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digues un numero: ");
                suma  = suma + Convert.ToInt32(Console.ReadLine());
                
            }

        }
    }
}
