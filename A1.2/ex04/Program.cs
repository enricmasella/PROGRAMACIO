// Declaració de variables
double a, b, x;

// Input
Console.Write("Introdueix el coeficient a (diferent de zero sino sera indeterminat): ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Introdueix el coeficient b: ");
b = Convert.ToDouble(Console.ReadLine());

// Process
x = -b / a;

// Output
Console.WriteLine($"L'equació és: {a}x + ({b}) 0");
Console.WriteLine($"La solució és: x = {x}");