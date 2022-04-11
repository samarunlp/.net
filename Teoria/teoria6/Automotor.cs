namespace Teoria6;

class Automotor{
   
   public string Marca = "";
   private int _modelo;
   public int Modelo{
       get=> _modelo;
       set=> _modelo = (value < 2005) ? 2005 :value;
   }
   
   //protected String Marca = ""; //en vez de ponerlas en priv, los pongo de esta manera para q puedan referenciarlo
   //protected int Modelo;

   public Automotor(String marca, int modelo)
   {
       this.Marca = marca;
       Modelo = modelo;
   }
   /* Si agrego un constructor se rompe auto y colectivo hay que agregar esto y en las clases 1 linea
   public Automotor()
   {
   }*/
   //public void Imprimir() ya no utlizo este sino el virtual
   public virtual void Imprimir()
       => Console.WriteLine($"{Marca} {Modelo}");
}
      
