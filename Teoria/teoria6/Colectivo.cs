namespace Teoria6;
/*
Se utiliza la clase automotor para heredar los atributos y agrego el que me falta
class Colectivo
{
   public string Marca = "";
   public int Modelo;
   public int CantPasajeros;
   public void Imprimir()
       => Console.WriteLine($"{Marca} {Modelo}");
}
*/
class Colectivo: Automotor
{
    public int CantPasajeros;

    public override void Imprimir()   //ojo cuando completa porque pone el base que es del padre que no utlizaremos
    => Console.WriteLine($"{Marca} {Modelo} ({CantPasajeros} pasajeros)");
 
 }
