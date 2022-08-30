// See https://aka.ms/new-console-template for more information
string marca= "Ford";
int modelo = 2000;
Console.WriteLine("Primera forma "); //Strings que normalmente utilizamos
Console.WriteLine(" Es un "+ marca+ " año "+ modelo);
//mejora
string st;
Console.WriteLine( "Segunda forma ");// Strings de formato compuesto
st= string.Format( " Es un {0} año {1}", marca, modelo);//cadenas de formato compuesto, indica no solo donde va sino que se le puede escribir info
Console.WriteLine(st);
Console.WriteLine( "Tercera forma ");// 
st= string.Format( $" Es un {marca} año {modelo}"); //interpolacion de string, con el signo peso entiende que es una marca de formato. Puede ponerse literales(int o una division)
Console.WriteLine(st);

Console.WriteLine("-------------------");
Console.WriteLine("Alineacion derecha");
Console.WriteLine($" Es un {marca,7} año {modelo}");//completa con blanco
Console.WriteLine($" Es un {"Nissan",7} año {2020}");
Console.WriteLine("Alineacion izquierda");
Console.WriteLine($" Es un {"Nissan",-7} año {2020}"); //completa con blanco

Console.WriteLine("-------------------");
double r= 2.417;
Console.WriteLine("Rodondeo un real, ejemplo: "+ r);
Console.WriteLine($"Valor = {r:0.0}"); //dps del punto la cantidad de decimales
Console.WriteLine($"Valor = {r:0.00}");

Console.WriteLine("Ejemplo máscara de formatos para DateTime");
DateTime fecha = new DateTime(1492,10,12,15,5,6,325);
Console.WriteLine("a) {0}", fecha);
Console.WriteLine("b) {0:d}", fecha); // le pide la forma corta con d 
Console.WriteLine("c) {0:D}", fecha); // le pide la forma larga con D
Console.WriteLine($"d) {fecha:dddd d 'del mes de' MMMM 'del año' yyyy}"); // dddd es el dia de la semana, d es el numero pero con 1 cifra, 
/*dd es el numero pero con 2 cifras, MMMM le pido el nombre completo del mes, MMM oct, MM 10, MM 10 porq justo es octubre sino si fuera marzo seria 03*/
Console.WriteLine($"e) {fecha:t}");
Console.WriteLine("f) {0:hh:mm:s fff}",fecha); //hh 2 cifras, h una cifra de la hora; mm 2 cifras, m una cifra de minuto;s una cifra de segundos; ffff milisegundos

//Copiar vectores diapo 43

Console.WriteLine("-------------------");
Console.WriteLine("Imprimir una lista");
List<int> lista= new List<int>(){10,20,30,40};
lista.Remove(30);//borra el elemento que ingreso entre parentesis y si hay 2 iguales borra el primero que encuentra, ej 30
lista.RemoveAt(1);//borra el elemento que se encuentra en la posicion que ingreso entre parentesis, ej 20
lista.Insert(2,22);//insertar en la posicion el elemento tal, ej en la posicion 2 poner el 22
lista.Add(55);//Agrega a lo último el 55
int[] vector=new int []{31,32,33}; //agregar una coleccion de elementos, tmb puede usarse una cola, pila
lista.InsertRange(3,vector);//a partir de la posicion 3 agrega esos 3 elementos
for(int i=0; i<lista.Count; i++){
    Console.WriteLine(lista[i] );//imprime uno bajo del otro.
}

Console.WriteLine();
Console.WriteLine("-------------------");
double[]? vector1=new double [10];
/*void Procesar(double []? v, int i, int c)
{
    c=c+10;
    v[i]=1000/c;//1000/11=90,90990909090  --> se va del rango del vector entonces no sirve este proceso
    Console.WriteLine(v[i]);
}*/
//mejor manera de arregarlo sera con try...catch
void Procesar(double[]? v, int i, int c)
{
try
    {
        c = c + 10;
        v[i] = 1000 / c;
        Console.WriteLine(v[i]);
    }
/*catch 
    {
        Console.WriteLine("No procesado");
    }   */ 
 catch (Exception e) //si quiero saber cual fue la excepcion(errores en tiempo de ejecucion) por la que no funciono
    {
        Console.WriteLine(e.Message); //el mensaje se codificara en otro lado
    }   
}

Procesar(vector1,1,1);
Procesar(vector, 10, 1);
Procesar(vector, -1, 1);
Procesar(vector, 1, -10);
Procesar(vector, 1, 1);
Console.WriteLine("-------------------");


Console.WriteLine("-------------------");
