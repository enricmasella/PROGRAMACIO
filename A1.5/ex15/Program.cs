namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("GIRONA.txt");

            string linea = sr.ReadLine();
            int puntos = 0;
            int victorias = 0, empates = 0, derrotas = 0;

            while (linea != null)
            {
                string girona = sr.ReadLine();

                int r = Convert.ToInt32(linea);
                int g = Convert.ToInt32(girona);

                if (g > r)
                {
                    victorias++;
                    puntos += 3;
                }
                else if (g == r)
                {
                    empates++;
                    puntos++;
                }
                else
                {
                    derrotas++;
                }

                linea = sr.ReadLine();
            }

            sr.Close();

            Console.WriteLine("Victorias: " + victorias);
            Console.WriteLine("Empates: " + empates);
            Console.WriteLine("Derrotas: " + derrotas);
            Console.WriteLine("Puntos: " + puntos);

        }
    }
}
