using System;

namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre;

            Console.Write("Introdueix un nombre enter de 3 xifres: ");
            nombre = Convert.ToInt32(Console.ReadLine());

            if (EsCapICua(nombre))
            {
                Console.WriteLine(nombre + " és cap-i-cua.");
            }
            else
            {
                Console.WriteLine(nombre + " no és cap-i-cua.");
            }
        }

        static bool EsCapICua(int n)
        {
            int centena, desena, unitat;
            int valor = n;

            centena = valor / 100;
            desena = (valor / 10) % 10;
            unitat = valor % 10;

            if (((centena != 0 && centena == unitat) ||
        (centena == 0 && desena != 0 && desena == unitat) ||
        (centena == 0 && desena == 0)))

                {
                    return true;
            }
            return false;
        }
    }
}
