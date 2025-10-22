// variables
double McinturaDada;
double Mcintura;
int talla;
const double Pulgadas = 2.54;

//input 
Console.WriteLine("Quina es la teva talla europea de roba?");
McinturaDada = Convert.ToDouble(Console.ReadLine());

//proces
Mcintura = McinturaDada * 2;
talla = (int)(Mcintura / Pulgadas);

//output
Console.WriteLine($"La teva talla americana entre la [{talla - 1} i la {talla} ]");