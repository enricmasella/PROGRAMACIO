// int a, b, c;
// a = Convert.ToInt32(Console.ReadLine());
// b = Convert.ToInt32(Console.ReadLine());
// c = a;
// a = b;
// b = c;
// Console.WriteLine(a);
// Console.WriteLine(b);


//variables
using System.Timers;

int a = 2;
int b = 3; 
int c;

//proces
c = a;
a = b;
b = c;

//output
Console.WriteLine("Els valor de 'a' i de 'b' al principi eren 2 i 3 respectivament, ara:");
Console.WriteLine($"El valor de a es: {a}");
Console.WriteLine($"El valor de b es: {b}");//Després de la línia 2: a = 2

//Després de la línia 3: b = 3

//Després de la línia 4: c = 2

//Després de la línia 5: a = 3

//Després de la línia 6: b = 2

//Les línies 7 i 8 mostren 3 i 2 respectivament.

//L'objectiu d'aquest programa és intercanviar els valors de les dues variables a i b.
