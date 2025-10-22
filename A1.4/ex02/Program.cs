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
            bool iguals;

            Console.WriteLine("value of t1?");
            t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of t2?");
            t2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of t3?");
            t3 = Convert.ToInt32(Console.ReadLine());

            iguals = t1 == t2 && t2 == t3;
            
            if (iguals)
            {
                Console.WriteLine("Les tres temperatures són iguals.");
            }
            else
            {
                Console.WriteLine("Les temperatures no són iguals.");
            }
        }
    }
}
