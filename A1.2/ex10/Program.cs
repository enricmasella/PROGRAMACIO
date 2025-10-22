//variables 
double peus;
double metros;

//input 
Console.WriteLine("Cuantos pies deseas pasar a metros?");
peus = Convert.ToDouble(Console.ReadLine());

//proces 
metros = peus * 12 / 39.27;

//output
Console.Clear();
Console.WriteLine("El calculo sera realizado por un simple factor de conversion:");
Console.WriteLine($"{peus} (pies) * 12 pulgadas (1 pie son 12 pulgadas) / por 39,27 ( 1 metro son 39,27 pulgadas).");
Console.WriteLine($"El resultado del calculo es: {peus} peus son {metros: .00} metros");