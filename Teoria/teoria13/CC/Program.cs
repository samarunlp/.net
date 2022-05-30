using Microsoft.Extensions.DependencyInjection;
using CalculoSimple;
//Calculador calc= new Calculador(); //depende de calculador
//ILogger logger= new Logger();

/*ILogger logger= new LoggerArchivo();
Calculador calc= new Calculador(logger); 
calc.Calcular(3);*/

//acoplamiento fuerte
/*evitar alta cohesión, dividir las cosas y agrupar comportamientos(cosas cohesivas que tengan pocas
dependencia*/

var servicios = new ServiceCollection();
//para que se lo de debe registrarlos a todos
servicios.AddTransient<ICalculador, Calculador>();//devuelve uno nuevo, transitorio. Cuando te pida un Icalculador devolveme una instancia de Calculador
servicios.AddTransient<ILogger, Logger> ();//ando te pida un ILogger devolveme una instancia de Logger
//var proveedor= new ProveedorServicios();
var proveedor= servicios.BuildServiceProvider();
var calc = proveedor.GetService <ICalculador>();
//ICalculador calc= proveedor.GetCalculador();
//calc.Calcular(3);
calc?.Calcular(3);
