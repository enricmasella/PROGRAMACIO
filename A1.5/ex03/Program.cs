namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i= 0;
            int numN= 0;
            int numP = 0;
            Console.WriteLine("Introdueix un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            { 
                if (num > 0)
                {
                    numP++;
                }
                else
                {
                    numN++;
                }

                Console.WriteLine("Introdueix un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                i++;

            }

            Console.WriteLine($"Has introduit {numP} numeros positius i {numN} numeros negatius, en total has posat {i} numeros.");
        }
    }
}
