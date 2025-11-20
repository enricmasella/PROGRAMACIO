namespace ex15
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani a l’usuari un número i que mostri un quadrat.
        /// ENTRA UN NÚMERO: 4
        /// ****
        /// ****
        /// ****
        /// ****
        /// </summary>
        static void Main(string[] args)
        {
            int num;
            char caracter;

            Console.Write("Introdueix un numero: "); num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdueix un caracter: "); caracter = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(GenerarLinia(caracter, num));
            }
        }
        public static string GenerarLinia(char car, int longitud)
        {
            string fila = "";

            for (int i = 0; i < longitud; i++)
            {
                fila += car;
            }

            return fila;
        }

    }
}
