namespace CalculoSimple;
class Calculador{
    //Logger _logger= new Logger(); //depende de logger 
    //ILogger _logger = new Logger();
    ILogger _logger;
    public Calculador(ILogger logger){ 
        _logger = logger;
    }
    public void Calcular(int n)
    {
        int resul= (n+5)*(n+7); //depende de int, los tipos primitivos tmb son dependencias pero no importa ese analisis,sino el que hagamos nosotros porque se puede modificar
        _logger.Log($"Fin de Calculo - (result={resul})"); //usando una intancia de la clase
    }
}
