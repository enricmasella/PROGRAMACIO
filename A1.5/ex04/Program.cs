namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int numN = 0;
            int numP = 0;
            string line;
            int num;


            StreamReader sr = new StreamReader("NUMEROS.txt");
            
             line = sr.ReadLine();
            while (line != null)
            {
                num = Convert.ToInt32(line);

                if (num > 0)
                {
                    numP++;
                }
                else
                {
                    numN++;
                }
                i++;
                line = sr.ReadLine(); 
             }
            

            Console.WriteLine($"Has introduit {numP} numeros positius i {numN} numeros negatius, en total has posat {i} numeros.");
        }
    }
}
