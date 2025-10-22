using System.Runtime.ConstrainedExecution;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = -10;

           
            Console.WriteLine(TrueFalse(a, b, c));
            // aixo podrem veure que es fals i que es true.
            //e1 = True,
            //e2 = True,
            //e3 = True,
            //e4 = False,
            //e5 = True,
            //e6 = True,
            //e7 = False,
            //e8 = False,
            //e9 = True,
            //e10 = True,
            //e11 = False
        }
        static string TrueFalse(int a, int b, int c)
        {
            bool e1 = a > 3;
            bool e2 = a > c;
            bool e3 = b != c;
            bool e4 = a == 3;
            bool e5 = a * b == 15;
            bool e6 = c / b < a;
            bool e7 = c / b == -10;
            bool e8 = a + b + c == 5;
            bool e9 = (a + b == 8) && (a - b == 2);
            bool e10 = (a + b == 8) || (a - b == 6);
            bool e11 = a > 3 && b > 3 && c < 3;

            string one = $"e1={e1},e2={e2},e3={e3},e4={e4},e5={e5},e6={e6},e7={e7},e8={e8},e9={e9},e10={e10},e11={e11}";

            return one;


        }
    }
}
