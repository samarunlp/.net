
string marca= "Ford";
int modelo = 2000;
Console.WriteLine("Primera forma ");
Console.WriteLine(" Es un "+ marca+ " año "+ modelo);
//mejora
string st;
Console.WriteLine( "Segunda forma ");
st= string.Format( " Es un {0} año {1}", marca, modelo);
Console.WriteLine(st);
Console.WriteLine( "Tercera forma ");
st= string.Format( $" Es un {marca} año {modelo}");  
Console.WriteLine(st);

Console.WriteLine("-------------------");
Console.WriteLine("Alineacion derecha");
Console.WriteLine($" Es un {marca,7} año {modelo}");
Console.WriteLine($" Es un {"Nissan",7} año {2020}");
Console.WriteLine("Alineacion izquierda");
Console.WriteLine($" Es un {"Nissan",-7} año {2020}"); 

Console.WriteLine("-------------------");
double r= 2.417;
Console.WriteLine("Rodondeo un real, ejemplo: "+ r);
Console.WriteLine($"Valor = {r:0.0}"); 
Console.WriteLine($"Valor = {r:0.00}");

Console.WriteLine("-------------------");
Console.WriteLine("Imprimir una lista");
List<int> lista= new List<int>(){10,20,30,40};
lista.Remove(30);
lista.RemoveAt(1);
lista.Insert(2,22);
lista.Add(55);
int[] vector=new int []{31,32,33};
lista.InsertRange(3,vector);
for(int i=0; i<lista.Count; i++){
    Console.WriteLine(lista[i] );
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
