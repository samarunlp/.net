namespace Teoria6;

class Auto: Automotor
{
    /* NO es necesario porque ya tengo uno con las mismas caracteristicas, utilizo el codigo
   public string Marca = "";
   public int Modelo;
   public TipoAuto Tipo;
   public void Imprimir()
       => Console.WriteLine($"{Marca} {Modelo}");*/
       
  public TipoAuto Tipo;
  //public Auto():base(marca, modelo); lo q hace el compilador para que no se rompa al poner public Auto:Automotor
  public Auto(String marca, int modelo, TipoAuto tipoAuto): base(marca, modelo){
         this.Tipo = tipoAuto;
     }
   public override void Imprimir() 
    {
    Console.Write($"Auto {Tipo}");
    base.Imprimir();
    }
}
