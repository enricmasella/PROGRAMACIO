using System.Linq.Expressions;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t1;
            int t2;
            int t3;
            bool dif;

            Console.WriteLine("value of t1?");
            t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of t2?");
            t2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of t3?");
            t3 = Convert.ToInt32(Console.ReadLine());

            dif = t1 != t2 && t2 != t3;

            if (dif)
            {
                Console.WriteLine("Les tres temperatures són totes diferents.");
            }
            else
            {
                Console.WriteLine("Les temperatures no són totes diferents.");
            }

        }
    }
}
