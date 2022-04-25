namespace Teoria8;
delegate int FuncionEntera(int n);
/*
Se puede declarar de 2 formas el delegado 
-f= SumaUno; 
-f = new FuncionEntera(SumaUno); //lo hace solo el compilador al constructor
                                 //los entornos de desarrollo suelen declararlo de esta manera, la forma mas explicita
describe de que forma son los metodos que puede recibir (no se guarda el metodo, tiene una referencia que sabe
 invocar el metodo)
 */
