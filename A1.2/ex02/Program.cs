//declaracio de variables 
int edatAnyVinent;
int edatActual;

// input 
Console.Write("Introdueix la teva edat actual: ");
edatActual = Convert.ToInt32(Console.ReadLine());

//proces 
edatAnyVinent = edatActual + 1;

//output
Console.WriteLine($"Aquest any tens {edatActual} anys.");
Console.WriteLine($"L'any vinent en tindràs {edatAnyVinent}.");