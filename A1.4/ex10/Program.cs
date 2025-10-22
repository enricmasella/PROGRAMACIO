namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int any;
            Console.WriteLine("Introdueix un any");
            any = Convert.ToInt32(Console.ReadLine());
            if (any <= 1700 || any >= 2101)
            {
                Console.WriteLine("Els anys tenen que ser entre 1701 i 2100");

            }
            else
            {
                Console.WriteLine($"{Segle(any)}");
            }
        }
        public static string Segle(int any)
        {
            string result;
            if (any <= 1800) 
            {
                result = $"El {any} pertany al segle XVIII ";
            }
            else if (any <= 1900 && any>= 1801)
            {
                result = $"El {any} pertany al segle XIX ";
            }
            else if (any <= 2000 &&  any>= 1901)
            {
                result = $"El {any} pertany al segle XX ";
            }
            else 
            {
                result = $"El {any} pertany al segle XXI ";
            }

            return result ;


        }

    }
}
