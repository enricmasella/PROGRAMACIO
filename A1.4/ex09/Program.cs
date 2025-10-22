namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaEx;
            double notaPr;
            Console.WriteLine("Quina es la nota del examen??");
            notaEx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quina es la nota de les practiques??");
            notaPr = Convert.ToInt32(Console.ReadLine());

            if (notaEx <= 3 || notaPr <= 3)
            {
                Console.WriteLine("Estas supés");
            }
            else
            {
                Console.WriteLine($"La mitjana surt de {NotaQualitativa(notaEx, notaPr)}");
            }
        }

        public static string NotaQualitativa(double notaExamen, double notaPractiques)
        {
            double result = notaExamen * 0.8 + notaPractiques * 0.2;
           return result.ToString();    
        }
    }
}
