using Teoria6;

/* Al tener el contructor y el override de Automotor no necesito escribir lo de abajo
Auto a = new Auto();
Colectivo c = new Colectivo();
a.Marca = "Ford";
a.Modelo = 2000;
c.Marca = "Mercedes";
c.Modelo = 2010;
c.CantPasajeros = 20;
a.Tipo = TipoAuto.Deportivo;*/
Auto a= new Auto(" Ford ", 2000, TipoAuto.Deportivo);
Colectivo c=new Colectivo("Mercedes", 2010, 20);
//a.Imprimir();
//c.Imprimir(); 
Console.WriteLine(a.Marca + " " + a.Modelo);
Console.WriteLine(a.Marca + " " + a.Modelo);
