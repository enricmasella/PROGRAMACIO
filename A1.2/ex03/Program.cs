//variables 
int hores;
int minuts;
int segons;
int totalSegons;

//input
Console.Write("Introdueix el nombre d'hores: ");
hores = Convert.ToInt32(Console.ReadLine());
Console.Write("Introdueix el nombre de minuts: ");
minuts = Convert.ToInt32(Console.ReadLine());
Console.Write("Introdueix el nombre de segons: ");
segons = Convert.ToInt32(Console.ReadLine());

//proces
totalSegons = (hores * 3600) + (minuts * 60) + segons;

// output
Console.WriteLine($" Temps introduït: {hores} hores, {minuts} minuts i {segons} segons");
Console.WriteLine($" Temps total en segons: {totalSegons} segons");
Console.WriteLine($" Càlcul: ({hores} × 3600) + ({minuts} × 60) + {segons} = {totalSegons}");



