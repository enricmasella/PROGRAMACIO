using System.Diagnostics.CodeAnalysis;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum= 0;
            Console.Write("Digues un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                sum = sum + i;
                Console.WriteLine(i);

            }
            Console.WriteLine($"El programa ha sumat, i el resultat es {sum}");
        }
    }
}
