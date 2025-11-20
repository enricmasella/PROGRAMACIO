internal class Program
{
    static void Main(string[] args)
    {
        int rep;
        Console.Write("QUANTS NUMEROS PERFECTES?: ");
        rep = Convert.ToInt32(Console.ReadLine());
        int i = 0, j = 2;

        while (i < rep)
        {
            if (EsPerfecte(j))
            {
                Console.WriteLine(j);
                i++;
            }
            j++;
        }
    }

    public static bool EsPerfecte(int rep)
    {
        int sum = 0;
        for (int i = 1; i <= rep / 2; i++)
        {
            if (rep % i == 0)
            {
                sum += i;
            }
        }
        return sum == rep;
    }
}
