namespace Teoria6;

class Auto: Automotor
{
  public TipoAuto Tipo;
  public Auto(String marca, int modelo, TipoAuto tipoAuto): base(marca, modelo){
         this.Tipo = tipoAuto;
     }
   public override void Imprimir() 
    {
    Console.Write($"Auto {Tipo}");
    base.Imprimir();
    }
}
