using System;
using System.Runtime.ConstrainedExecution;

namespace Ex17
{
    internal class Program
    {
        /// <summary>
        ///Fes un programa que mostri per pantalla totes les taules de multiplicar del 0 al 10.
        /// Opcional
        /// Utilitzar el procediment MostrarTaula, que mostri per pantalla la taula de multiplicar d’un número
        /// passat per paràmetre.
        /// public static void MostrarTaula(int numTaula)
        /// </summary>
        static void Main(string[] args)
        {
            int num;

            Console.Write("Introdueix un numero: "); 
            num = Convert.ToInt32(Console.ReadLine());

            MostrarTaula(num);
            
        }
        public static void MostrarTaula(int numTaula)
        {
            int result;
            
            for (int i = 0; i <= 10; i++)
            {
                result= i * numTaula;
                Console.WriteLine($"{numTaula} x {i} = {result}");
            }
        }

    }
}
