namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("NUMEROS.txt");
            string line;
            int i = 0;
            line = sr.ReadLine();
            
            while (line != null)
            {
                i++;
                line = sr.ReadLine();
            }

            sr.Close();
            Console.WriteLine($"Ha llegit null despres de contar {i} lines, llavors en la linea {i + 1} no hi ha res escrit.");


        }
    }
}
