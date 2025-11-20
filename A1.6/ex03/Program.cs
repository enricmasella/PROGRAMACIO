namespace ex03
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani dos números i mostri per pantalla tots els valors compresos entre
        /// aquests dos números.
        /// ENTRA n1: 5
        /// ENTRA n2: 900
        /// 5, 6, ………., 900
        /// </summary>
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Introdueix un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introdueix un altre numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}
