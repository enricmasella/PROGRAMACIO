namespace ex04
{
    internal class Program
    {
        /// <summary>
        /// Modifica l’anterior programa fent que no es mostrin els números que siguin múltiples de 7.
        /// </summary>
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Introdueix un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introdueix un altr numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                if (i % 7 != 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
