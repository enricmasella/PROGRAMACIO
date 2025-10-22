//variables
int divisor;
int divident;
int residu;
int divisio;


//input
Console.WriteLine("Càlcul de residu en una divisió entera, Introdueix el divident:  ");
divident = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ara introdueix el divisor:  ");
divisor = Convert.ToInt32(Console.ReadLine());

//proces
divisio = divident / divisor;
residu = divident % divisor;

//output
Console.WriteLine($"El resultat de dividir {divident} entre {divisor} és:  {divisio} ");
Console.WriteLine($"El residu de la divisió és: {residu} ");