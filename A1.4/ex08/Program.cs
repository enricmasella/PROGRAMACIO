namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h, m, s;
            int hora24h;

            Console.WriteLine("diguem una hora en format 24 h");
            hora24h = Convert.ToInt32(Console.ReadLine());
            h = hora24h / 10000;
            m = hora24h / 100 % 100;
            s = hora24h % 100;

            if (HoraValida(h, m, s))
            {
                Console.WriteLine($"La hora donada, {hora24h}, es valida i correcte!");
            }
            else
            {
                 Console.WriteLine($"La hora donada, {hora24h}, es incorrecta i no es valida!");
            }

        }
            
        public static bool HoraValida(int h, int m, int s)
        {
            bool res;
            if (h > 24 || m >= 60 || s >=60 )
            {
                res = false;
            }
            else
            {
                res = true;
            }
            return res;    
           
          
        }
    }
}
