namespace UBUNTU
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                string user = "root";
                string password = "toor";
                int intents = 1;

            Console.Write("Introdueix el nom d'userClient: ");
                string userClient = Console.ReadLine();

                Console.Write("Introdueix la contrasenya: ");
                string contrasenya = Console.ReadLine();

                while (userClient != user || contrasenya != password)
                {
                    Console.Clear();
                    Console.WriteLine($"USUARI O CONTRASENYA INCORRECTE. {intents} INTENT");
                    Console.Write("Introdueix el nom d'userClient: ");
                    userClient = Console.ReadLine();

                    Console.Write("Introdueix la contrasenya: ");
                    contrasenya = Console.ReadLine();
                    intents++;

                }

            Console.WriteLine("BENVINGUT AL SISTEMA.");
            
        }

    }
}

