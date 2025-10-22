namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int any;
            

            //input 
            Console.WriteLine("introdueix un número enter que representi un any:");
            any = Convert.ToInt32(Console.ReadLine());


            //proces 
           Suma(any);   


            //output
            Console.WriteLine($"La suma de les xifres son: {Suma(any)}");
           
        }

        static int Suma(int anyT)
        {
            int numero1 = (anyT / 1000) % 10;
            int numero2 = (anyT / 100) % 10;
            int numero3 = (anyT / 10) % 10;
            int numero4 = (anyT ) % 10;
            return numero1 + numero2 + numero3 + numero4;
            
        }



    }
}
