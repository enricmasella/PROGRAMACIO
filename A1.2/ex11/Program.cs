// variables 
int horesT;
double souBxH;
double impostSB;
double souNet;
double souBrutT;
double retencioImp;

//input
Console.WriteLine("Insereix les teves hores treballades:");
horesT =  Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ara el sou Brut per hora treballada:");
souBxH = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Per ultim el percentatge d'impost aplicat al sou brut total:");
impostSB = Convert.ToInt32(Console.ReadLine());

//proces 

souBrutT = souBxH * horesT;
retencioImp = souBrutT*impostSB / 100;
souNet = souBrutT - retencioImp;

//output

Console.WriteLine(" Segons les dades ingresades:");
Console.WriteLine($" 1r. El sou brut total: {souBrutT}");
Console.WriteLine($" 2n. La retencio d'impostos es de: {retencioImp}");
Console.WriteLine($" 3r. El sou net es de: {souNet}");

