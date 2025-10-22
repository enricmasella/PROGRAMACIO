//variables
int caresD;
Random random = new Random();
int result;

//input
Console.WriteLine("cuantas caras tiene el dado??");
caresD = Convert.ToInt32(Console.ReadLine());

//proces
result = random.Next(1, caresD);

//output 
Console.WriteLine($"El dau ha tret un {result}");
