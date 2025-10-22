namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pulgadas;
            const double cm = 0.0254;

            Console.Write("Enter length in inches: ");
            pulgadas = Convert.ToDouble(Console.ReadLine());
            ConvertToMeters(pulgadas, cm);
            double meters = ConvertToMeters(pulgadas, cm);
            Console.WriteLine($"{pulgadas} inches = {Math.Round(meters, 4)} meters");
            
        }
        static double ConvertToMeters(double pulgadas, double conversorCmaM)
        {
            double metros = (pulgadas * conversorCmaM);
            return metros;

        }
    }
}
