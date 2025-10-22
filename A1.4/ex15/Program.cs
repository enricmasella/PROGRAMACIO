using System;

namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h, m, s;

            Console.Write("Introdueix les hores: ");
            h = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introdueix els minuts: ");
            m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introdueix els segons: ");
            s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hora inicial: " + h.ToString("D2") + ":" + m.ToString("D2") + ":" + s.ToString("D2"));
            Console.WriteLine("Hora +1 segon: " + Incrementa1Segon(h, m, s));
        }

        public static string Incrementa1Segon(int h, int m, int s)
        {
            s += 1;

            if (s == 60)
            {
                s = 0;
                m += 1;
            }

            if (m == 60)
            {
                m = 0;
                h += 1;
            }

            if (h == 24)
            {
                h = 0;
            }

            return h.ToString("D2") + ":" + m.ToString("D2") + ":" + s.ToString("D2");
        }
    }
}
