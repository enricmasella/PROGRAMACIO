//variables 
using static System.Runtime.InteropServices.JavaScript.JSType;

double a;
double b;
double c;
double x1;
double x2;
//input
Console.WriteLine("Introdueix el valor de a:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Introdueix el valor de b:");
b = Convert.ToDouble(Console.ReadLine());
//proces
x1= ((-b + (Math.Sqrt(Math.Pow(b,2)-4 * a * c)))/ 2*a);
x2 = ((-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / 2 * a);
//output
Console.WriteLine($"Les solucions son x1 = {x1} i x2 = {x2}");
