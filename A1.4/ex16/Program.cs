using System;

namespace Gulamatu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdueix un any: ");
            int any = Convert.ToInt32(Console.ReadLine());

            bool esTraspas = EsAnyTraspas(any);
            bool esHulukulu = EsAnyFestivalHulukulu(any);
            bool esBulukulu = EsAnyFestivalBulukulu(any);

            if (esTraspas)
                Console.WriteLine("Any de traspàs");
            else if (esHulukulu)
                Console.WriteLine("Festival Huluculu");
            else if (esBulukulu)
                Console.WriteLine("Festival Bulukulu");
            else
                Console.WriteLine("Aquest és un any normal");
        }

        public static bool EsAnyTraspas(int any)
        {
            return (any % 4 == 0 && any % 100 != 0) || (any % 400 == 0);
        }

        public static bool EsAnyFestivalHulukulu(int any)
        {
            return any % 15 == 0;
        }

        public static bool EsAnyFestivalBulukulu(int any)
        {
            return any % 55 == 0 && EsAnyTraspas(any);
        }
    }
}
