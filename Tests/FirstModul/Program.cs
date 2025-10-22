namespace FirstModul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 6;
            int res = Potencia2(valor1);
            Console.WriteLine($"El cuadrado de {valor1} es {res}");
        }
        static int Potencia2(int numero)
        {
            int resultat = numero * numero;
            return resultat;
        }
    }
}
