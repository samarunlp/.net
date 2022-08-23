// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//VER QUE IMPRIME
{
    object obj= 7.3;//obj apunta a un valor de tipo double
    Console.WriteLine(obj.GetType());
    obj="Casa";//ahora de tipo string
    Console.WriteLine(obj.GetType());
    oBj=4;//ahora de tipo int
    Console.WriteLine(obj.GetType());
/*
LO QUE IMPRIME
System.Double
System.String
System.Int32
La idea es que el "obj" siempre es de tipo object-->es dinamico, lo cual me permite poder asignarle cualquier tipo. 
*/
}

//SABE IMPRIMIR OBJETOS DE CUALQUIER TIPO
{
    object obj= 7.3;//obj apunta a un valor de tipo double
    Console.WriteLine(obj);
    obj="Casa";//ahora de tipo string
    Console.WriteLine(obj);
    obj=4;//ahora de tipo int
    Console.WriteLine(obj);
/*LO QUE IMPRIME
7,3
Casa
4
La idea es que el "obj" es tan dinamico que me permite poder imprimir cualquier tipo cuando lo invoca el obj.ToString()
*/
}
    
// Convertir un obj en entero
{
//Console.WriteLine(obj+1); // no se puede porque hay que castearlo de la siguiente manera entonces tengo que hacer:
Console.WriteLine((int)obj + 1); //conversion explicita del contenido de la variable obj-->imprime 5
}

//SOBRECARGAS en este caso del operador + -->Esta en las diapositivas 42 
{
    object obj= 1+ 2.3;
    Console.WriteLine(obj.GetType());//System.Double
    Console.WriteLine(obj);//3.3
}
{
    object obj= 1 + 'A'; //toma el valor ascii de A(65)
    Console.WriteLine(obj.GetType());//System.Int32    
    Console.WriteLine(obj);//66
}
{
    object obj= "CAS" + 'A'; //concatena una cadena, se da cuenta que era un string y toma como un caracter
    Console.WriteLine(obj.GetType()); //System.String  
    Console.WriteLine(obj); //CASA
}
{
    object obj= "Área" + 51; //concatena una cadena porque "Area" es un string, toma la suma como 2 strings
    Console.WriteLine(obj.GetType()); //System.String  
    Console.WriteLine(obj); //Área51
}
    
//Depende el orden la suma cambia
{ 
    //El + ejecuta de izq a derecha
    object obj= "Área" + 5 + 1;// toma como string
    Console.WriteLine(obj.GetType()); //System.String  
    Console.WriteLine(obj); //"Área51"

    //El + ejecuta de izq a derecha
    object obj= 5 + 1 + "Área" ;// toma como int
    Console.WriteLine(obj.GetType()); //System.String  
    Console.WriteLine(obj); //"6Área"
}
    
//Sistema de tipos-->el valor null
{
    int? i1=null;//OK, el signo significa que admite el valor null(ya no figura un error de compilacion)
    string? st1=null; //OK
    int i2=null; //asignar null a una variable de un tipo de valor provoca un error de compilacion
    string st2=null;//asignar null a una variable de tipo de referencia provoca solo un warning del compilador. Es un string no es necesario ponerle null si puedo iniciarlo como "" 
//gracias al signo(?) en los primeros 2 no tira error.
}

//Tener cuidado a la hora de imprimir
{
    int var1;
    Console.WriteLine(var1); //No va a imprimir porque no tiene ningun valor asignado, tira error de compilacion
}

//Usando tipos de valor que admiten null
{
    int i = 1;
    int? j = i; //conversion implicita
    i = (int)j; //es necesario castear, conversion explicita
    j = null; 
    i = (int)j; //el valor de j es null, no puedo pedirle una conversion
    //
    i = j.HasValue ? j.Value : -1; 
    i = j != null ? (int)j : -1;
    i = j ?? -1; //null coalescing, el "??" es un operador que si lo de la izquierda es distinto de null devuelve lo de la izquierda y si es null me devuelve lo de la derecha --> es lo mismo que i = j.HasValue ? j.Value : -1;
}


//Como sacar el warning
{
    string st1 = "casa";
    string? st2 = st1;
    st1 = st2; // la forma para sacar el warning es -->st1 = st2 ?? ""; VER
    st1 = st2 != null ? st2 : "default";
    st1 = st2 ?? "default";
}

//Con el operador is podemos consultar por el tipo de una expresión o contenido de una variable. Devuelve un bool.
{
    object o = 1;
    Console.WriteLine(o is int); //true
}


//MISMOS EJEMPLOS, UNO DA FALSO Y EL OTRO VERDADERO(LA SEGUNDA VEZ QUE IMPRIME)
//VERDADERO, FALSO
{
    char c1='A';
    char c2= 'A';
    //Console.WriteLine(c1==c2);//True porque compara los contenidos 
    object o1= 'A';
    object o2= 'A'; 
    /*Console.WriteLine(o1==o2); /*False, porque es un objeto que tienen una direccion de 
    memoria, no compara el contenido sino la secuencia de bit*/
}
//VERDADERO, VERDADERO
{
    char c1='A';
    char c2= c1;
    //Console.WriteLine(c1==c2);//True 
    object o1= 'A';
    object o2= o1;  
    //Console.WriteLine(o1==o2); //True (Apuntan al mismo objeto)
}
