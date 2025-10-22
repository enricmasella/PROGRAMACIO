using System;

namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            int any;

            Console.Write("Introdueix un any: ");
            entrada = Console.ReadLine();
            any = Convert.ToInt32(entrada);

            if (EsAnyDeTraspas(any))
            {
                Console.WriteLine(any + " és de traspàs.");
            }
            else
            {
                Console.WriteLine(any + " no és de traspàs.");
            }
        }

        static bool EsAnyDeTraspas(int any)
        {
            if ((any % 4 == 0 && any % 100 != 0) || (any % 400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}