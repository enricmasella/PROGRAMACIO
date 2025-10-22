using System;

class Program
{
    static void Main()
    {
        int suma = 0;
        int i = 0;
        string line;
        StreamReader sr = new StreamReader("NUMEROS.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            line = line.Convert
            suma = suma + ;
            i++;

            Console.Write("Introdueix un altre número: ");
            num = Convert.ToInt32(Console.ReadLine());
        }

        if (i > 0)
        {
            double mitjana = suma / i;
            Console.WriteLine($"La mitjana dels valors introduïts és: {mitjana} i has posat {i} numeros.");
        }

    }
}
