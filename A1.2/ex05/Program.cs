//declaracio de variables 
char lletra;
int codiASCII;
// input
Console.WriteLine("Prem una lletra en el teclat per tal de pasarla a ASCII");
lletra = Convert.ToChar(Console.Read());
//proces 
codiASCII = (int)lletra;

//output
Console.WriteLine($"El codi ASCII es {codiASCII}");