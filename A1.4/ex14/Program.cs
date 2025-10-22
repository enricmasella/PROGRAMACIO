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
            int milers, centena, desena, unitat;
            int valor = n;

            milers = valor / 1000;
            centena = (valor / 100) % 10;
            desena = (valor / 10) % 10;
            unitat = valor % 10;

            if ((milers != 0 && milers == unitat && centena == desena) ||
                (milers == 0 && centena != 0 && centena == unitat && desena == 0) ||
                (milers == 0 && centena == 0 && desena == 0))
            {
                return true;
            }
            return false;
        }

    }
}
