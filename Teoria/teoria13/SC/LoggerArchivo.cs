namespace CalculoSimple;
//ejemplo de implementacion de la teoria, no lo usa despues
class LoggerArchivo : ILogger 
{
    public void Log(string mensaje)
    {
        using var sw = new StreamWriter("registro.log", true); 
        sw.WriteLine ($"{DateTime.Now} {mensaje}");
    }
}
