namespace ex08
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani per teclat un número i calcule el producte del número 1 al numero entrat per l’usuari.
        /// ENTRA UN NÚMERO: 4
        /// 24 //1*2*3*4
        /// NOTA: El producte d’un número...es coneix amb el nom del factorial.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int num;
            int multi = 1;

            Console.Write("Introdueix un numero: "); num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                multi *= i;
            }

            Console.WriteLine($"El producte del numero 1 al numero {num} es {multi}");
        }
    }
}
