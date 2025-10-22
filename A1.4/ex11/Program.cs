namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angle;
            Console.WriteLine("Introdueix unn angle: ");
            angle = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine(Quadrant(angle));
        }
        public static string Quadrant(double angle)
        {
           
            string result = "";
            if (angle > 0 && angle <= 90)
            {
                result = $"El angle {angle} pertany al quadrant I";

            }
            if (angle > 90 && angle <= 180)
            {
                result = $"El angle {angle} pertany al quadrant II";

            }
            if (angle > 180 && angle <= 270)
            {
                result = $"El angle {angle} pertany al quadrant III";

            }
            if (angle > 270 && angle <= 360)
            {
                result = $"El angle {angle} pertany al quadrant IV";

            }

            return result;
                



        }
    }
}
