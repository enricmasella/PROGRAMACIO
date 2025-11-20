namespace ex02a
{
    internal class Program
    {
        /// <summary>
        /// Donada una seqüència d’enters, informar si el primer valor es repeteix.
        /// Versió 2: La seqüència prové del teclat i acaba amb -9999.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Introdueix la seqüència d'enters (un per línia, acaba amb -9999):");
            int primerValor = 0;
            int valorActual;
            bool primerValorLlegit = false;
            bool valorRepetit = false;

            while (true)
            {
                string entrada = Console.ReadLine();
                valorActual = Convert.ToInt32(entrada);

                if (!primerValorLlegit)
                {
                    primerValor = valorActual;
                    primerValorLlegit = true;
                    continue;
                }
                if (valorActual == -9999)
                    break;
                if (valorActual == primerValor)
                    valorRepetit = true;
            }

            if (valorRepetit)
                Console.WriteLine("El primer valor es repeteix.");
            else
                Console.WriteLine("El primer valor no es repeteix.");
        }
    }
}
