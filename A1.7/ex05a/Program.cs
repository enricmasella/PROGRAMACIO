using System.ComponentModel.Design;

namespace ex5a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, i= 1;
            Console.Write("ENTER A NUMBER: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (i <= num / 2 && sum <= num)
            {
                if ( num % i == 0 )
                {
                    sum += i;
                }
                i++;
            }
            if ( sum == num )
            {
                Console.WriteLine($"{num} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{num} is not a perfect number");
            }           
        }
    }
}
