/*int [] vector = new int [] {1,2,3,4,5};
IEnumerable<int> secuencia = vector.Select(n => n*3);//generalmente se los llamada secuencia porque estan en orden 
*/
List<string> lista = new List<string>(){"uno","dos","tres"};
IEnumerable <string> secuencia = lista.Select(st => "(" + st.ToUpper() + ")");
Mostrar(secuencia); 
IEnumerable <int> secuencia2 = secuencia.Select(st=> st.Length);
Mostrar(secuencia2); 
IEnumerable <double> secuencia3 = secuencia2.Select(dou => dou / 2.0);
Mostrar(secuencia3); 
//se puede hacer todo en uno, como esta en el pdf

void Mostrar<T>(IEnumerable<T> secuencia)
{
    foreach(T elemento in secuencia)
    {
        Console.WriteLine(elemento + "");
    }
    Console.WriteLine();
}
