//PRIMERA TEORIA

//USO DE VARIABLES
double d=15.1;
float f=21.2f;
double resultado = 1/2;
Console.WriteLine(resultado);

//PEDIR INGRESAR POR TECLADO
Console.WriteLine("Ingrese su nombre");
string st = Console.ReadLine();
Console.WriteLine("Hola " + st);

//Ejercicio: solicitar al usuario que ingrese por teclado un numero n y calcular 
// la sumatoria desde 1 hasta n 
{
    Console.WriteLine("Ingrese un numero ");
    int n = int.Parse(Console.ReadLine()); /
    int suma=0;
    for (int i=1;i<= n;i++){
        suma+= i;
}
Console.WriteLine("La suma desde 1 hasta " + n + " es de " + suma);
}

//SEGUNDA TEORIA
//Conversiones que suelen hacerse que tiran error
//Ejemplo 1
{byte b=10;
double x=12.25;
int i=b; 
double y=i; 
short j=(short)i; 
i= (short)x;
/
}

//Ejemplo 2
{
int i= int.Parse("321");
d = int.Parse("321.34")
i= Convert.ToInt32(true);
}

//Boxing y Unboxing
{
    Object o;
    int i=123;
    o=1; 
    int j= (int) o; 

    7.ToString();
    "casa".GetType();
}
