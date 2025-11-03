using System.Diagnostics.CodeAnalysis;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int mult = 1;
            Console.Write("Digues un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                mult = mult * i;
                Console.WriteLine(i);

            }
            Console.WriteLine($"El programa ha multiplicat, i el resultat es {mult}");
        }
    }
}
