//declaracio de variables 
char lletraMinuscula;
char lletraMajuscula;

// input
Console.WriteLine("Escriu una lletra minuscula");
lletraMinuscula = Convert.ToChar(Console.Read());
 

//proces 
lletraMajuscula = (char)(lletraMinuscula - 32);

//output
Console.WriteLine($"La lletra '{lletraMinuscula}' en Majuscula es: '{lletraMajuscula}'.");
