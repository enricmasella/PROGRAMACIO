// variables
double McinturaDada;
double Mcintura;
int talla;
const double Pulgadas = 2.54;

//input 
Console.WriteLine("Quina es la teva talla americana de roba?");
McinturaDada = Convert.ToDouble(Console.ReadLine());

//proces
Mcintura = McinturaDada * Pulgadas;
talla = (int)(Mcintura / 2);

//output
Console.WriteLine($"La teva talla europea es la {talla}");