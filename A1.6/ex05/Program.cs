namespace ex05
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani 10 números per teclat i que els sumi. Al final del recorregut ha de
        /// mostrar la sum de tots els números.
        /// </summary>

        static void Main(string[] args)
        {
            int sum = 0;
            int num;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Introdueix un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                sum += num;
            }

            Console.WriteLine($"La suma total es {sum}");
        }
    }
}
