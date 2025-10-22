internal class Program
{
    private static void Main(string[] args)
    {
        // variables
        double x1;
        double x2;
        double y1;
        double y2;

        //input 
        Console.Write("Enter x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        // proces
        double result = distane(x1, y1, x2, y2);
        //output
        Console.WriteLine($"Distance: {result:.000}");
        double distane(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}