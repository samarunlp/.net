namespace Teoria7;

class Empleado : Persona, IImprimible, IComparable
{
   //Si me paro sobre IComparable y aprieto 'ctrl+.' implementa la interfaz
   public Empleado(string nombre)//agrega
      => Nombre = nombre;
   public void Imprimir()//agrega
      => Console.WriteLine($"Soy el empleado {Nombre}");

   public int CompareTo(object? obj)//agrega pero no pone 'CompareTo', ojo
    {
        int result = 0;
        if(obj is Empleado)
        {
           string nombre = ((Empleado)obj).Nombre; //orden alfabetico de los nombres
           result= this.Nombre.CompareTo(nombre);
        }
        return result;
    }
}

