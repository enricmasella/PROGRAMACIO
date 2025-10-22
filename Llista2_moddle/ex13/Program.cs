//variables 
double celsius;
double fahrenheit;
//input
Console.WriteLine("Quina es la temperatura en graus Celsius?");
celsius = Convert.ToDouble(Console.ReadLine());
//proces
fahrenheit = (celsius * 9 / 5) + 32;
//output
Console.WriteLine($"El calcul es (Celsius * 9/5) + 32");
Console.WriteLine($"Llavors la temperatura en graus Fahrenheit es {fahrenheit:.00}ºF");

 