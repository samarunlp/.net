using Teoria7;
/*
Utilizan el polimorfismo-->IImprimible
Interfaces úeden heredar de multiples interfaces
*/
/*
object[] vector = new object[] {
       new Moto("Zanella"),
       new Empleado("Juan"),
       new Moto("Gilera")
   };
*/
//mejora seria
IImprimible[] vector = new IImprimible[] {
       new Moto("Zanella"),
       new Empleado("Juan"),
       new Moto("Gilera")
   };

/*foreach (object o in vector)
{
   if(o is Empleado e)
   {
    //Equivale a hacer Empleado e = e(o is Empleado)
     e.Imprimir();
   }
   else if(o is Moto m)
   {
       m.Imprimir();
   }
}*/

//utilizamos polimorfismo
foreach (IImprimible imp in vector)
{
    imp.Imprimir(); //imp esuna conversion de tipo de object a IImprimible
}

var vector1 = new Empleado[]{
                new Empleado("Juan"),
                new Empleado("Adriana"),
                new Empleado("Diego")
};
Array.Sort(vector1);
/*Tirra un error, no se puede hacer Polimorfismo con el metodo Sort()
pero podemos utlizar IComparable, se modifica en "Empleado" */
//Imprime el vector ordenado
foreach(Empleado e in vector1)
{
    e.Imprimir();
}
