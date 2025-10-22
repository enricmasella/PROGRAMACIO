namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double EUR;
            double USD;


            Console.Write("Enter amount in EUR: ");
            EUR = Convert.ToDouble(Console.ReadLine());
           
            USD = ConvertToUSD(EUR, 1.175);

            Console.WriteLine($"{EUR} EUR = {USD:F2} USD");
        }       
        static double ConvertToUSD(double qtyEuros, double euro2Dollar)
        {
            double dollars = qtyEuros * euro2Dollar;
            return dollars;
        }
    }
}

