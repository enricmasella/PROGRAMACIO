namespace ex02
{
    internal class Program
    {
        /// <summary>
        ///Escriure els 20 primers números parells.
        /// 2, 4, 6,......... 40
        /// </summary>
        static void Main(string[] args)
        {
            int parell = 0;
            int x;
            for (x = 1; parell <= 20; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine(x);
                    parell++;
                }
            }
        }
    }
}
