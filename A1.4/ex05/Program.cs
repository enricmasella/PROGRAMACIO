namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());



            if (EsParell(num) == true)
            {
                Console.Write("Es un nombre parell i ");
            }
            else
            {
                Console.Write("Es un nombre senar i ");

            }


            if (EsMultipleDe7(num) == true)
            {
                Console.Write("es multiple de 7.");

            }
            else
            {
                Console.Write("no es un nombre multiple de 7.");

            }

        }
        public static bool EsParell(int nu)
        {
            if (nu % 2 == 0)
            {
                return true;
            }
            else { return false; }
        }
        public static bool EsMultipleDe7(int n)
        {
            if (n % 7 == 0)
            {
                return true;
            }
            else
            { return false; }
        
        
        }

    }
}
