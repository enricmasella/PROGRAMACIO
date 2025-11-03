namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int intentos = 0;
            bool correcto = false;

            while (!correcto)
            {
                int a = rnd.Next(1, 101);
                int b = rnd.Next(1, 101);
                intentos++;

                Console.WriteLine("A = " + a + "   B = " + b);

                Console.Write("Suma: ");
                int s = Convert.ToInt32(Console.ReadLine());

                Console.Write("Resta: ");
                int r = Convert.ToInt32(Console.ReadLine());

                Console.Write("Producto: ");
                int p = Convert.ToInt32(Console.ReadLine());

                Console.Write("División entera: ");
                int d = Convert.ToInt32(Console.ReadLine());

                if (s == a + b && r == a - b && p == a * b && d == a / b)
                    correcto = true;
                else
                    Console.WriteLine("Error. Repite.");
            }

            Console.WriteLine("¡Correcto! Iteraciones: " + intentos);

        }
    }
}
