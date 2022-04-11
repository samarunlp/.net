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
    //va tener su propia propiedad
    public override int Modelo{
      protected set=>
        base.Modelo = (value < 2015) ? 2015 :value;
   }
//public Colectivo():base(marca, modelo);
    public Colectivo(String marca, int modelo, int cantPasajeros): base (marca, modelo){
        this.CantPasajeros = cantPasajeros;
     }
     
//override para que funcione el polimorfismo
    public override void Imprimir()
    => Console.WriteLine($"{Marca} {Modelo} ({CantPasajeros} pasajeros)"); //si se ponen en privado en automotres sale error en marca y modelo; lo hereda pero no me deja referenciarlo
}
