// See https://aka.ms/new-console-template for more information
string marca= "Ford";
int modelo = 2000;
Console.WriteLine("Primera forma ");
Console.WriteLine(" Es un "+ marca+ " año "+ modelo);
//mejora
string st;
Console.WriteLine( "Segunda forma ");
st= string.Format( " Es un {0} año {1}", marca, modelo);//cadenas de formato compuesto, indica no solo donde va sino que se le puede escribir info
Console.WriteLine(st);
Console.WriteLine( "Tercera forma ");
st= string.Format( $" Es un {marca} año {modelo}"); //interpolacion de string, con el signo peso entiende que es una marca de formato  
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

Console.WriteLine("-------------------");
Console.WriteLine("Imprimir una lista");
List<int> lista= new List<int>(){10,20,30,40};
lista.Remove(30);//borra el elemento que ingreso entre parentesis y si hay 2 iguales borra el primero que encuentra, ej 30
lista.RemoveAt(1);//borra el elemento que se encuentra en la posicion que ingreso entre parentesis, ej 20
lista.Insert(2,22);//insertar en la posicion el elemento tal, ej en la posicion 2 poner el 22
lista.Add(55);//Agrega a lo último el 55
int[] vector=new int []{31,32,33};
lista.InsertRange(3,vector);//a partir de la posicion 3 agrega esos 3 elementos
for(int i=0; i<lista.Count; i++){
    Console.WriteLine(lista[i] );//imprime uno bajo del otro.
}

Console.WriteLine();
Console.WriteLine("-------------------");
double[]? vector1=new double [10];
Procesar(vector1,1,1);
void Procesar(double []? v, int i, int c)
{
    c=c+10;
    v[i]=1000/c;//1000/11=90,90990909090
    Console.WriteLine(v[i]);
}
Console.WriteLine("-------------------");


Console.WriteLine("-------------------");
