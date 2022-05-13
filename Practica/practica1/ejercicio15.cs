/*
15. Escribir un programa que solicite un año por pantalla y diga si es bisiesto. Un año es
bisiesto si es divisible por 4 pero no por 100. Si es divisible por 100, para ser bisiesto
debe ser divisible por 400.
*/

//VER
Console.WriteLine("Ingrese un año");
int ao = int.Parse(Console.ReadLine());
if (ao % 100 == 0){
   if (ao % 400 == 0){
      Console.WriteLine("El año es bisiesto");
   }else if (ao % 4 == 0){
        Console.WriteLine("El año es bisiesto");
}else{
  Console.WriteLine("El año no es bisiesto");
}
