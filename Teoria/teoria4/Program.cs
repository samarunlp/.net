
//En el programa.cs poner
using Teoria4;
//trabajamos con la clase auto

//Auto a
Auto a;
a = new Auto("Nissan", 2017);
//a.Marca= "Nissan"; si fuera publica
/* Como se imprime si no se hace un metodo de instancia 
Console.WriteLine($"Auto {a.Marca} {a.Modelo}");
*/
Console.WriteLine(a.GetDescripcion());

//Auto b
Auto b =new Auto("Ford",2015);
Console.WriteLine(b.GetDescripcion());

//Auto c, gracias al constructor sin parametros puedo definir ese tipo
Auto c = new Auto(); //utilizando el constructor 2-->podria hacerse con el tipo a, a= new Auto();
Auto d = new Auto("Renault"); //utlizando el constructor 3
Console.WriteLine(a.GetDescripcion());
