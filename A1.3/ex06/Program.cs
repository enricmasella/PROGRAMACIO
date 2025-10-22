namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables 
            int horesT;
            double souBxH;
            double impostSB;
            double souNet;
            double souBrutT;
            double retencioImp;

            //input
            Console.WriteLine("Insereix les teves hores treballades:");
            horesT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ara el sou Brut per hora treballada:");
            souBxH = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Per ultim el percentatge d'impost aplicat al sou brut total:");
            impostSB = Convert.ToInt32(Console.ReadLine());

            //proces 
            souBrutT = souBrutTotal(souBxH, horesT);
            retencioImp = retencioImpostos(souBrutT, impostSB);
            souNet = souNett(souBrutT, retencioImp);


            //output

            Console.WriteLine(" Segons les dades ingresades:");
            Console.WriteLine($" 1r. El sou brut total: {souBrutT}");
            Console.WriteLine($" 2n. La retencio d'impostos es de: {retencioImp}");
            Console.WriteLine($" 3r. El sou net es de: {souNet}");

        }
        static double souBrutTotal(double souBxH, int horesT)
        {
            return souBxH * horesT;
        }
        static double retencioImpostos(double souBrutT, double impostSB)
        {
            return souBrutT * impostSB / 100;
        }
        static double souNett(double souBrutT, double retencioImp)
        {
            return souBrutT - retencioImp;
        }
    }
}
