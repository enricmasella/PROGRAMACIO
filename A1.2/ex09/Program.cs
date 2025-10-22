//declaracio de variable
const double Pulgadas = 2.54/ 100;
double metros;
double resultado;


// input

Console.WriteLine("Cuantas pulgadas deseas convertir a metros?");
resultado =  Convert.ToDouble(Console.ReadLine());  

//proces
metros = resultado *  Pulgadas;

//output 
Console.WriteLine($" Entonces {resultado} pulgadas * {Pulgadas}m (2.54cm) son {metros} metros ");
