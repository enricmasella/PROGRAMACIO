namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            int i = 0;
            int final = 0;
            int ?num;
            Console.Write("Enter a number: ");
            num= Convert.ToInt32(Console.ReadLine());

            while ( num != final )
            {
                i++;
                Console.Write("Enter a number: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"You entered {i} numbers before entering {final}");
        }
    }
}
