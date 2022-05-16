List<string> lista = new List<string>(){"uno","dos","tres"};
IEnumerable <string> secuencia = lista.Select(st => "(" + st.ToUpper() + ")");
Mostrar(secuencia); 
IEnumerable <int> secuencia2 = secuencia.Select(st=> st.Length);
Mostrar(secuencia2); 
IEnumerable <double> secuencia3 = secuencia2.Select(dou => dou / 2.0);
Mostrar(secuencia3); 

void Mostrar<T>(IEnumerable<T> secuencia)
{
    foreach(T elemento in secuencia)
    {
        Console.WriteLine(elemento + "");
    }
    Console.WriteLine();
}


var personas = Persona.GetLista();
personas.ForEach(p=> Console.WriteLine(p)); 
Console.WriteLine();
personas.Where(p => p.Edad >= 18).ToList().ForEach(p=> Console.WriteLine(p)); 
