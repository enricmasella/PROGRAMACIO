//variables 
using System.Text;

double dolar; 
double EUR;
double EURDonats;

//input
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Cuantos euros ( € ) son un dolar ( $ )?");
EURDonats = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Cuanto dinero desea convertir:");
EUR = Convert.ToDouble(Console.ReadLine());

//proces
dolar = EUR / EURDonats;

// output
Console.WriteLine($"La conversion donaria: {dolar: 0.00}$ son {EUR}€  ");