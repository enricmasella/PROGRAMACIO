//variables
const double pi = 3.14159;
double radi;
double volum;

//input
Console.WriteLine("quin es el radi de l'esfera ( en cm )?");
radi = Convert.ToDouble(Console.ReadLine());

//proces
volum = ((4.0 / 3)* pi * radi * radi * radi );

//output
Console.WriteLine($"El volum de l'esfera es {volum:.00}cm^3 i els calculs son :");
Console.WriteLine($"4/3 * PI (3,14159) * radi^3");