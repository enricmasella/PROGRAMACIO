namespace ex10
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que mostri tots els números múltiples de 4 entre el 0 i el 300.
        /// ● Després de mostrar 20 números, el programa ha de pausar-se fins que que l’usuari premi una tecla.
        /// ● Utilitza la instrucció Console.ReadKey() per esperar que l’usuari entri una tecla.
        /// </summary>
        static void Main(string[] args)
        {
            int i, j, mult4 = 0;

            for (i = 0; mult4 < 20; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                    mult4++;
                }
            }

            Console.Write("Prem una tecla per continuar: ");
            Console.ReadKey();
            Console.WriteLine();

            for (j = i; j <= 300; j++)
            {
                if (j % 4 == 0)
                {
                    Console.WriteLine(j);
                    mult4++;
                }
            }

        }
    }
}
