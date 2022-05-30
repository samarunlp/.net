using CalculoSimple;
//Calculador calc= new Calculador(); //depende de calculador
//ILogger logger= new Logger();
ILogger logger= new LoggerArchivo();
Calculador calc= new Calculador(logger); 
calc.Calcular(3);
//acoplamiento fuerte
/*evitar alta cohesión, dividir las cosas y agrupar comportamientos(cosas cohesivas que tengan pocas
dependencia*/
