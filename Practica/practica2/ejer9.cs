/*
9. Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué
circunstancias es preferible utilizar StringBuilder en lugar de utilizar string? Implementar
un caso de ejemplo en el que el rendimiento sea claramente superior utilizando
StringBuilder en lugar de string y otro en el que no.
*/
/*
Acerca de la clase StringBuilder:
  -Es una clase que permite crear objetos que almacenan cadenas de caracteres que pueden ser modificadas sin necesidad de 
crear nuevos objetos
  -Está indexado. Cada uno de sus caracteres tiene un índice: 0 para el primero,1 para el segundo, etc.
  
Es preferible usar StringBuilder cuando: el valor del objeto puede cambiar gran número de veces y solo será modificado por un mismo hilo o thread 
(lo más habitual),ya que al no ser sincronizado es más rápido y tiene mejor rendimiento.
*/

//Caso donde el rendimiento es claramente superior utilizando StringBuilder en lugar de string
using System.Text;
String myString = "";
for (int i = 0; i < 100; i++)
    myString += " "; // poner 100 espacios en el string
Console.WriteLine(myString);

/*Debido a la copia repetida y la creación de objetos, esto 
degradará significativamente el rendimiento de nuestro programa. 
Podemos evitar esto utilizando en su lugar un StringBuilder .*/
//De la siguiente manera:

StringBuilder myStringBuilder = new StringBuilder();
for (int i = 0; i < 100; i++)
    myStringBuilder.Append(' '); 
Console.WriteLine(myStringBuilder);

//Caso donde el rendimiento es claramente inferior utilizando StringBuilder en lugar de string
using System.Text;
String myString = "Hola";
myString += " Mundo";
Console.WriteLine(myString);

StringBuilder myStringBuilder = new StringBuilder("Hola");
myStringBuilder.Append(" Mundo"); 
Console.WriteLine(myStringBuilder);
