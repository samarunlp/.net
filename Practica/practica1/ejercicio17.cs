/*
17. Utilizar el operador ternario condicional para establecer el contenido de una variable entera con
el menor valor de otras dos variables enteras.
*/
VER

Random rnd = new Random();
int a=rnd.Next(1, 50), b=rnd.Next(1,50);
int x = (a<b) ? a : b; //si la condicion es verdadera se queda con la primer opción
Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(x);
Console.ReadLine();
 }
