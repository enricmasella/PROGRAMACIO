namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
    
            Console.Write("Radio: ");
            int r = Convert.ToInt32(Console.ReadLine());
            int r2 = r * r;

            StreamReader sr = new StreamReader("coordenades.txt");
            string lineaX = sr.ReadLine();

            while (lineaX != null)
            {
                int x = Convert.ToInt32(lineaX);

                // Marca de fin: x == 0 => fin del recorrido
                if (x == 0) break;

                string lineaY = sr.ReadLine();
                int y = Convert.ToInt32(lineaY);

                int d = x * x + y * y;

                if (d < r2)
                    Console.WriteLine("Punto (" + x + "," + y + ") dentro");
                else if (d == r2)
                    Console.WriteLine("Punto (" + x + "," + y + ") sobre");
                else
                    Console.WriteLine("Punto (" + x + "," + y + ") fuera");

                lineaX = sr.ReadLine();
            }

            sr.Close();

        }
    }
}
