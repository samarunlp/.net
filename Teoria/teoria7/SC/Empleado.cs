namespace Teoria7;

class Empleado : Persona, IImprimible, IComparable
{
   public Empleado(string nombre)
      => Nombre = nombre;
   public void Imprimir()
      => Console.WriteLine($"Soy el empleado {Nombre}");

   public int CompareTo(object? obj)
    {
        int result = 0;
        if(obj is Empleado)
        {
           string nombre = ((Empleado)obj).Nombre;
           result= this.Nombre.CompareTo(nombre);
        }
        return result;
    }
}
