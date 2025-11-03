namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("BONUS2.TXT");
            string linea = sr.ReadLine();
            int totalBonus = 0, ganancias = 0;

            while (linea != null)
            {
                if (linea == "BONUS")
                {
                    string cantidad = sr.ReadLine();
                    ganancias += Convert.ToInt32(cantidad);
                    totalBonus++;
                }

                linea = sr.ReadLine();
            }

            sr.Close();

            Console.WriteLine("BONUS: " + totalBonus);
            Console.WriteLine("Ganancias totales: " + ganancias);

        }
    }
}
