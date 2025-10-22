using System.Security.Cryptography;

namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radi;
            const double PI = 3.14159;

            Console.Write("Entra el radi de l'esfera: ");
            radi = Convert.ToDouble(Console.ReadLine());

            Volume(radi, PI);
            Area(radi, PI);
            perimetre(radi, PI);

            Console.WriteLine($"El volum de l'esfera es: {Volume(radi, PI)}");
            Console.WriteLine($"L'area de l'esfera es: {Area(radi, PI)}");
            Console.WriteLine($"El perimetre de l'esfera es: {perimetre(radi, PI)}");


        }
        static double Volume(double radi, double PI)
        {
            double volum = (4.0 / 3.0) * PI * Math.Pow(radi, 3);
            return volum;
        }
        static double Area(double radi, double PI)
        {
            double area = 4 * PI * Math.Pow(radi, 2);
            return area;
        }
        static double perimetre(double radi, double PI)
        {
            double perimetre = 2 * PI * radi;
            return perimetre;
        }
    }
}
