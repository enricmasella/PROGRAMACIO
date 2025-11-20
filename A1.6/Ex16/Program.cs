using static System.Net.Mime.MediaTypeNames;

namespace ex16
{
    internal class Program
    {
        /// <summary>
        /// Fes un programa que demani a l’usuari un número i que mostri una piràmide.
        /// ENTRA UN NÚMERO: 4
        /// *
        /// **
        /// ***
        /// ****
        /// Utilitzar la funció GenerarLinia, que genera una cadena de text d'una longitud específica amb un
        /// caràcter donat.
        /// public static string GenerarLinia(char car, int longitud)
        /// </summary>
        static void Main(string[] args)
        {
            int num;
            char caracter;

            Console.Write("Introdueix un numero: "); num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introdueix un caracter: "); caracter = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(GenerarLinia(caracter, i));                
            }
        }
        public static string GenerarLinia(char car, int longitud)
        {
            string fila = "";

            for (int i = 0; i <= longitud; i++)
            {
                fila += car;
            }

            return fila;
        }
    }
}
