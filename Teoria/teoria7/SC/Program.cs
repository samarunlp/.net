using Teoria7;

IImprimible[] vector = new IImprimible[] {
       new Moto("Zanella"),
       new Empleado("Juan"),
       new Moto("Gilera")
   };

foreach (IImprimible imp in vector)
{
    imp.Imprimir(); 
}

Console.WriteLine();

var vector1 = new Empleado[]{
                new Empleado("Juan"),
                new Empleado("Adriana"),
                new Empleado("Diego")
};
Array.Sort(vector1);

foreach(Empleado e in vector1)
{
    e.Imprimir();
}

//
Console.WriteLine();
Pyme miPyme = new Pyme (new Empleado ("Juan"), 
                        new Empleado("Adriana"),
                        new Empleado("Diego"));
foreach (Empleado e in miPyme)
{
    e.Imprimir();
}
