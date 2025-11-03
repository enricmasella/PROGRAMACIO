namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int mult = 0;
            Console.Write("Digues un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int resultat = num * mult;
                Console.WriteLine($"{num} x {mult} = {resultat}");
                mult++;
            }
        }
    }
}
