//variables
double fahrenheit;  
double celsius;
//input
 Console.WriteLine("Quina es la temperatura en graus Fahrenheit?");
 fahrenheit = Convert.ToDouble(Console.ReadLine());
//proces
celsius = (fahrenheit - 32) * 5 / 9;
//output
Console.WriteLine($"El calcul es (Fahrenheit - 32) * 5/9");
Console.WriteLine($"Llavors la temperatura en graus Celsius es {celsius:.00}ºC");