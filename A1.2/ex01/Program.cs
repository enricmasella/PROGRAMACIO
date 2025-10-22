// Llegir un número enter de l'entrada  i  el converteix a int

int n = Convert.ToInt32(Console.ReadLine());

// Incrementa el valor de n en 1
n = n + 1;

// Mostrar el valor original (n-1) i el valor incrementat (n) 
Console.WriteLine($"HAS ENTRAT : {n - 1} I UN MÉS VAL {n}");

// Mostrar el valor original i el incrementat amb format de 4 dígits (amb zeros a l'esquerra si cal)
Console.WriteLine($"HAS ENTRAT : {n - 1:0000} I UN MÉS VAL {n:0000}");