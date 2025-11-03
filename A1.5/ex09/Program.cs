namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número positivo: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int cifras = 0;

            while (num > 0)
            {
                num = num / 10;
                cifras++;
            }
            Console.WriteLine("Tiene " + cifras + " cifras.");

        }
    }
}
