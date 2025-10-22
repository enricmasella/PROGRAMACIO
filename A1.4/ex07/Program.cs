using System.ComponentModel.Design;
using System.Text;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int V;
            Console.WriteLine("A quina velocitat va el coche?");
            V = Convert.ToInt32(Console.ReadLine());



           Console.WriteLine(Sancio(V));



            //cal retornar 100€, 300€, 600€+retirada de carnet o bé “sense sanció”
            //● tram 1 de 80 Km / h a 99 Km / h, (100€ de multa)
            //● tram 2 de 100 Km / h a 129 Km / h(300€ de multa)
            //● tram 3 de 130 Km / h en endavant. (600€ de multa) i retirada de carnet

        }

        public static string Sancio(int velocitat)
        {
            string resultat = "";
            if (velocitat >= 80 && velocitat < 100)
            {
                resultat = $"Si el coche va a {velocitat}, la multa es de 100€ i no es retira el carnet ";
            }

            else if (velocitat >= 100 && velocitat < 130)
            {

                resultat = $"Si el coche va a {velocitat}, la multa es de 300€ i no es retira el carnet ";
            }
            else if (velocitat >= 130)
            {
                resultat = $"Si el coche va a {velocitat}, la multa es de 600€ + retirada de carnet ";
            }
            else 
            {
                resultat = $"Si el coche va a {velocitat}, no hi ha multa ni tampoc retirada de carnet";
            }
                return resultat;

        }


    }
}
