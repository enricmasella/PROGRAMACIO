
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//variables
double Cobro;
double Canvi;
double valueCompra;
const int cien = 10000;     
const int cinquenta = 5000; 
const int veinte = 2000;    
const int diez = 1000;      
const int cinco = 500;     
const int dos = 200;        
const int uno = 100;        
const int c50 = 50;         
const int c20 = 20;         
const int c10 = 10;         
const int c5 = 5;           
const int c2 = 2;           
const int c1 = 1;    
int restant;
int billetes100, billetes50, billetes20, billetes10, billetes5;
int Moneda2, Moneda1;   
int Cent50, Cent20, Cent10, Cent05, Cent02, Cent01;


//input 
Console.WriteLine("Cuanto vale la compra del cliente?");
valueCompra = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Cuanto dinero te da el cliente?");
Cobro = Convert.ToDouble(Console.ReadLine());


// procés
Canvi = Cobro - valueCompra;
restant = (int)Math.Round(Canvi * 100);
billetes100 = 0, billetes50 = 0, billetes20 = 0, billetes10 = 0, billetes5 = 0;
Moneda2 = 0, Moneda1 = 0;
Cent50 = 0, Cent20 = 0, Cent10 = 0, Cent05 = 0, Cent02 = 0, Cent01 = 0;

//utilitzo el Console.Write per veure la variacio de restant.
//Console.WriteLine(restant);
billetes100 = restant / cien; restant %= cien;
//Console.WriteLine(restant);
billetes50 = restant / cinquenta; restant %= cinquenta;
//Console.WriteLine(restant);
billetes20 = restant / veinte; restant %= veinte;
//Console.WriteLine(restant);
billetes10 = restant / diez; restant %= diez;
billetes5 = restant / cinco; restant %= cinco;
Moneda2 = restant / dos; restant %= dos;
Moneda1 = restant / uno; restant %= uno;
Cent50 = restant / c50; restant %= c50;
Cent20 = restant / c20; restant %= c20;
Cent10 = restant / c10; restant %= c10;
Cent05 = restant / c5; restant %= c5;
Cent02 = restant / c2; restant %= c2;
Cent01 = restant / c1; restant %= c1;

//output
Console.WriteLine($"El canvi ha de ser: {Canvi:.00}€");
Console.WriteLine("El desglos de billets i monedes és:");
Console.WriteLine($"{billetes100} Billets de 100€");
Console.WriteLine($"{billetes50} Billets de 50€");
Console.WriteLine($"{billetes20} Billets de 20€");
Console.WriteLine($"{billetes10} Billets de 10€");
Console.WriteLine($"{billetes5} Billets de 5€");
Console.WriteLine($"{Moneda2} Monedes de 2€");
Console.WriteLine($"{Moneda1} Monedes de 1€");
Console.WriteLine($"{Cent50} Monedes de 50 cèntims");
Console.WriteLine($"{Cent20} Monedes de 20 cèntims");
Console.WriteLine($"{Cent10} Monedes de 10 cèntims");
Console.WriteLine($"{Cent05} Monedes de 5 cèntims");
Console.WriteLine($"{Cent02} Monedes de 2 cèntims");
Console.WriteLine($"{Cent01} Monedes de 1 cèntim");