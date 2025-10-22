//variables 
int a;
int b;
int c;
int d;
int e;
int aux;
//input
Console.WriteLine("Enter value for a:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value for b:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value for c:");
c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value for d:");
d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter value for e:");
e = Convert.ToInt32(Console.ReadLine());
//proces
aux = b;
b = a;
a = aux;
aux = c;
c = a;
a = aux;
aux = d;
d = a;
a = aux;
aux = e;
e = a;
a = aux;

//output 
Console.WriteLine("The values now are:");
Console.WriteLine($"a: {a}, b: {b}, c: {c}, d: {d}, e: {e}");




//ouput
Console.WriteLine($"The new value of a is: {a}");
Console.WriteLine($"The new value of b is: {b}" );
Console.WriteLine($"The new value of c is: {c}" );
Console.WriteLine($"The new value of d is: {d}" );
Console.WriteLine($"The new value of e is: {e}" );
