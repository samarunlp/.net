//Crear una carpeta "teoria4", crear un nuevo archivo "Auto.cs" y ṕoner

namespace Teoria4;
class Auto{
/*las variables que se declaran son privadas por defecto, no puedo utilizarlas mediante "a."
 en le programa */
//  public string? Marca; //signo para aceptar el nulo y si la quiero dejar publica
  private string? _marca;
  private int _modelo;

//sobrecarga de constructores
//constructor 1
  public Auto(string marca, int modelo)
  {
     _marca = marca;
     _modelo = modelo;
  }
  
 //constructor 2
   public Auto()
  {
     _marca = "Fiat";
     _modelo = DateTime.Now.Year;
  }
  
  //constructor 3
  //utilizando el this puedo llamar(invoco) al constructor sin parametros
   public Auto(string marca) :this()
  {
     _marca = marca;
  }
  
//método
/*Hace lo mismo pero es otra forma de hacerlo
 public string GetDescripcion(){ 
     return $"Auto {_marca} {_modelo}";
 }
*/
  public string GetDescripcion() =>
      $"Auto {_marca} {_modelo}";


}
