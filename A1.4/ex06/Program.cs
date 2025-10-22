using System.Reflection.Metadata.Ecma335;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int golsL, golsV;
            string nomL, nomV;
            Console.WriteLine("Quien es el equipo local?");
            nomL = Console.ReadLine();
            if (nomL == null)
            {
                Console.WriteLine("No se ingresó ningún nombre.");
                return;
            }
            Console.WriteLine("Goles del equip local?");
            golsL = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y el nombre del equipo visitnte?");
            nomV = Console.ReadLine();
            if (nomV == null)
            {
                Console.WriteLine("No se ingresó ningún nombre.");
                return;
            }
            Console.WriteLine("Cuantos goles a metido el visitante?");
            golsV = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( InformeResultat(nomL, golsL, nomV, golsV ));


        }
        public static string InformeResultat(string nomL, int golsEquipLocal, string nomEquipVisitant, int golsEquipVisitant)
        {
            string resultat = "";

            if (golsEquipLocal > golsEquipVisitant)
            {
                resultat= $"{nomL} ha guanyat al {nomEquipVisitant} amb un resutat de {golsEquipLocal} a {golsEquipVisitant}";

            }
            else if (golsEquipVisitant ==  golsEquipLocal)
            {
                resultat = ($"{nomL} ha empatat contra el {nomEquipVisitant} amb un resutat de {golsEquipLocal} a {golsEquipVisitant}");
            }
            
           else
           {
                resultat = ($"{nomL} ha perdut contra {nomEquipVisitant} amb un resutat de {golsEquipLocal} a {golsEquipVisitant}");
           }

            return resultat;
                
        }
    }


}
