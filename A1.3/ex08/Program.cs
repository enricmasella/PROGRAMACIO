using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Cuants segons vols donar de entrada?");
            int segons = Convert.ToInt32(Console.ReadLine());


            //proces
            Time(segons);

            //output 
            Console.WriteLine($"{Time(segons)}");

        }
        static string Time(int segons)
        {
            int h = segons / 3600;
            int min = (segons % 3600) / 60;
            int s = segons % 60; 
            return $"{segons} segons es exactament:  {h:00}:{min:00}:{s:00}" ;
        }
    }
}
