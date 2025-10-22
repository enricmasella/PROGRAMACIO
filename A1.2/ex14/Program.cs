//variables 
int h;
int min;
int s;
int segons;
//input
Console.WriteLine("Cuants segons vols donar de entrada?");
segons= Convert.ToInt32(Console.ReadLine());


//proces
h = segons / 3600;
min = (segons % 3600) / 60;
s = (segons % 3600) % 60;

//output 
Console.WriteLine($"{segons} segons es exactament:  {h:00}:{min:00}:{s:00}");
