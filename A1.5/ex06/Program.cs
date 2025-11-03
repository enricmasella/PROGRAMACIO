using System;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader("NUMEROS2.TXT");
        string linea = sr.ReadLine();

        int suma = 0, contador = 0;

        while (linea != null)
        {
            int num = Convert.ToInt32(linea);
            if (num == 0) break;

            suma += num;
            contador++;

            linea = sr.ReadLine();
        }

        sr.Close();
        Console.WriteLine("Media: " + (suma / contador));


    }
}
