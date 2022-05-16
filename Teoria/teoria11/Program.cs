//LINQ es para tratar IEnumerables. Es una caracteristica de .net

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

var personas = Persona.GetLista();
//personas.ForEach(p=> Console.WriteLine(p)); //el foreach es de la lista generica porque linq no tiene
//Console.WriteLine();
//personas.Where(p => p.Edad >= 18).ToList().ForEach(p=> Console.WriteLine(p)); //con el toList lo convierto en list<personas> y luego lista las personas mayores de edad

/*
.Select ( p => new {Nombre = p.nombre, Condicion = p.edad <18> "Menor" :"Mayor"}) crear objetos de un tipo anonimo, declara el nombre y utliza la condicion (creador ternario) para sacaber si es mayor de edad*/

//con grup puedo elegir el criterio de agrupacion
//grup.Key gruardo el valor por el cual yo lo agrupe, por ej argentina, bolivia
//grup.count me devuelve la cantidad de grupos que almaceno

//si quiero ordenarlo por edad, primero deberia haberse agrupado por edad y luego miro cual es menor
var agrupadas= personas.GroupBy(p => p.Nombre[0]).OrderByDescending(g => g.Key); //utliza la inicial e invierte los valores
foreach (var grupo in agrupadas)
{
    Console.WriteLine($"Inicial: {grupo.Key}");
    grupo.ToList().ForEach(p => Console.WriteLine (" - " + p));
}
