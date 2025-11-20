namespace Ex06
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani 10 números per teclat. En acabar el programa ha d’informar de
        /// quants números son positius, negatius i zeros
        /// </summary>
        static void Main(string[] args)
        {
            int num;
            int Positius = 0, Negatius = 0, Zero = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Introdueix un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {
                    Positius++;
                }
                else if (num < 0)
                {
                    Negatius++;
                }
                else
                {
                    Zero++;
                }
            }

            Console.WriteLine($"Has introduit {Positius} numeros positius, {Negatius} numeros negatius i {Zero} zeros");

        }
    }
}
