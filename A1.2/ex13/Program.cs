//variables
int any;
int numero1;
int numero2;    
int numero3;
int numero4;

//input 
Console.WriteLine("introdueix un número enter que representi un any:");
any = Convert.ToInt32(Console.ReadLine());


//proces 
numero1 =  (any % 10000 / 1000);
numero2 =  (any % 1000 / 100);
numero3 = (any % 100 / 10);
numero4 = (any % 10);


//output
Console.WriteLine($"Els numeros son:");
Console.WriteLine(numero1);
Console.WriteLine(numero2); 
Console.WriteLine(numero3);
Console.WriteLine(numero4);


