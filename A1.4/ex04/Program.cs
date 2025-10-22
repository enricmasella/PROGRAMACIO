using System.Linq.Expressions;

namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t1;
            int t2;
            int t3;
            bool ordreCreixent;
            Console.WriteLine("value of t1?");
            t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of t2?");
            t2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of t3?");
            t3 = Convert.ToInt32(Console.ReadLine());
            ordreCreixent = t1 <= t2 && t2 <= t3;
            if (ordreCreixent)
            {
                Console.WriteLine("Les temperatures estan en ordre creixent estricte.");
            }
            else
            {
                Console.WriteLine("Les temperatures no estan en ordre creixent estricte.");
            }
        }
    }
}
