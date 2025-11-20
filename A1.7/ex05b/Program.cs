using System;

namespace ex5b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("ENTER A NUMBER: ");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (EsPerfecte(num))
                Console.WriteLine($"{num} is a perfect number");

            
            else
                Console.WriteLine($"{num} is not a perfect number");


        }
        public static bool EsPerfecte(int n)
        {
            int sum = 0, i = 1;

            while (i <= n / 2 && sum <= n)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
                i++;
            }
            if (sum == n)
            {
                return true;
            }
            else             {
                return false;

            }
    }
}
