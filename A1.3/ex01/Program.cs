namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            int h;
            int min; 
            int sec;
           
            // input
            Console.Write("Enter hours: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter minutes: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter seconds: ");
            sec = Convert.ToInt32(Console.ReadLine());

            // proces 
            toSeconds(h, min, sec);

            // output
            Console.WriteLine($"Total seconds: {toSeconds(h, min, sec)}");

        }
        static int toSeconds(int h, int min, int sec)
        {
            return h * 3600 + min * 60 + sec;
        }

    }
}
