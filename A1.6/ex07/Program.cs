namespace ex07
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani per teclat un número i calcule la sum del número 1 al número entrat
        /// per l’usuari.
        /// ENTRA UN NÚMERO: 4
        /// 10 //1+2+3+4
        /// </summary>
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

            Console.Write("Introdueix un numero: "); num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }

            Console.WriteLine($"La sum del numero 1 al numero {num} es {sum}");
        }
    }
}
