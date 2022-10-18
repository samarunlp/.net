
//Teoria 11


List<string> lista = new List<string>() { "uno", "dos", "tres" };
IEnumerable<string> secuencia = lista.Select(st => "(" + st.ToUpper() + ")");
Mostrar(secuencia);
IEnumerable<int> secuencia2 = secuencia.Select(st => st.Length);
Mostrar(secuencia2);
IEnumerable<double> secuencia3 = secuencia2.Select(n=>n/2.0);
Mostrar(secuencia3);

void Mostrar<T>(IEnumerable<T> secuencia)
{
  foreach (T elemento in secuencia)
  {
    Console.Write(elemento + " ");
  }
Console.WriteLine();
}  
{
var numeros = new List<int>() { 1, 10, 7, 3, 11 };
Mostrar(numeros);
var mayores6 = numeros.Where(n => n > 6);
Mostrar(mayores6);
var reverso = mayores6.Reverse();
Mostrar(reverso);
var ordenados = reverso.OrderBy(n => n);  //aca puedo modificar para ordenar segun atributos, o con lo que se quiera 
Mostrar(ordenados);
var suma = ordenados.Sum();
var promedio = ordenados.Average();
Console.WriteLine($"suma: {suma} promedio:{promedio:0.00}");
}
{
var suma = Enumerable.Range(1, 20)    // 1, 2, 3, ..., 20 , ese range es el rango, no el contenido, ejem, si fuera de 10 a 20 serian 9 lugares. 
           .Select(n => n * n)  // 1, 4, 9, ... 400
           .Sum(); // 1 + 4 + 9 + ... + 400
Console.WriteLine($"Resultado: {suma}");
}

//Imprimir personas mayores a 18 años
var personas = Persona.GetLista();
personas.ForEach(p => Console.WriteLine(p)); // lista todas las personas
Console.WriteLine();
personas.Where(p => p.Edad >= 18).
ToList().
ForEach(p => Console.WriteLine(p)) ;

personas.OrderBy(p => p.Edad)
.Select(p => new { Nombre = p.Nombre, Condición = p.Edad < 18 ? "Menor" : "Mayor" })
.ToList()
.ForEach(obj => Console.WriteLine(obj));
