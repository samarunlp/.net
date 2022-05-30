using Microsoft.Extensions.DependencyInjection;
using CalculoSimple;

var servicios = new ServiceCollection();
servicios.AddTransient<ICalculador, Calculador>();
servicios.AddTransient<ILogger, Logger> ();
var proveedor= servicios.BuildServiceProvider();
var calc = proveedor.GetService <ICalculador>();
calc?.Calcular(3);
