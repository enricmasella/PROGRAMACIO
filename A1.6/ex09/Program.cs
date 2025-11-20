namespace Ex09
{
    internal class Program
    {
        /// <summary>
        /// Escriu un programa que demani un número per teclat. El programa ha de mostrar la taula de
        /// multiplicar de l‘1 al 10 del número entrat per teclat.
        /// ENTRA UN NÚMERO: 2
        /// 2 x 0 = 0
        /// 2 x 1 = 2
        /// ...
        /// 2 x 10 = 20
        /// </summary>

        static void Main(string[] args)
        {
            int num;
            int resultat;

            Console.Write("Introdueix un numero: "); num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                resultat = i * num;
                Console.WriteLine($"{num} x {i} = {resultat}");
            }
        }
    }
}
