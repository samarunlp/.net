namespace CalculoSimple;
class LoggerArchivo : ILogger 
{
    public void Log(string mensaje)
    {
        using var sw = new StreamWriter("registro.log", true); //escribe el mensaje en un registro log
        sw.WriteLine ($"{DateTime.Now} {mensaje}");//escribe una fecha en el archivo
    }
}
