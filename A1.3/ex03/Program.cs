namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            char lletra;
            //input
            Console.Write("Enter a lowercase letter: ");
            lletra = Convert.ToChar(Console.Read());
            //process
            Majuscula(lletra);

        }
        static void Majuscula(char lletramin)
        {
           char Majuscula= (char)(lletramin-32);
           Console.WriteLine($"The uppercase letter is: {Majuscula}");
          
        }

    }
}
