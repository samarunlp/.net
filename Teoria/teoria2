// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//VER QUE IMPLIME
/*
object obj= 7.3;//obj apunta a un valor de tipo double
Console.WriteLine(obj.GetType());
obj="Casa";//ahora de tipo string
Console.WriteLine(obj.GetType());
oBj=4;//ahora de tipo int
Console.WriteLine(obj.GetType());

LO QUE IMPRIME
System.Double
System.String
System.Int32
*/


//SABE IMPRIMIR OBJETOS DE CUALQUIER TIPO
{
/*
object obj= 7.3;//obj apunta a un valor de tipo double
Console.WriteLine(obj);
obj="Casa";//ahora de tipo string
Console.WriteLine(obj);
obj=4;//ahora de tipo int
Console.WriteLine(obj);
*/
/*LO QUE IMPRIME
7,3
Casa
4
*/
/* Convertir un obj en entero--> "Console.WriteLine(obj+1); " no se puede porque hay 
que castearlo de la siguiente manera: */
//Console.WriteLine((int)obj + 1); //conversion explicita del contenido de la variable obj-->imprime 5
}

//SOBRECARGAS-->Esta en las diapositivas
{/*
    object obj= 1+ 2.3;
    Console.WriteLine(obj.GetType());//System.Double
    Console.WriteLine(obj);//3.3
*/}
{/*
    object obj= 1 + 'A'; 
    Console.WriteLine(obj.GetType());//System.Int32    
    Console.WriteLine(obj);//66
*/}
{/*
    object obj= "CAS" + 'A';
    Console.WriteLine(obj.GetType()); //System.String  
    Console.WriteLine(obj); //CASA
*/}
{/*
    object obj= "Área" + 51;
    Console.WriteLine(obj.GetType()); //System.String  
    Console.WriteLine(obj); //Área51
*/}
{/*
    //El + ejecuta de izq a derecha
    object obj= "Área" + 5 + 1;// 
    Console.WriteLine(obj.GetType()); //System.String  
    Console.WriteLine(obj); //"Área51"
*/}
{/*
    //El + ejecuta de izq a derecha
    object obj= 5 + 1 + "Área" ;// 
    Console.WriteLine(obj.GetType()); //System.String  
    Console.WriteLine(obj); //"6Área"
*/}
{/*
    int? i1=null;//OK
    string? st1=null; //OK
    int i2=null; //asignar null a una variable de un tipo de valor provoca un error de compilacion
    string st2=null;//asignar null a una variable de tipo de referencia provoca solo un 
//warning del compilador. Es un string no es necesario ponerle null si puedo iniciarlo como "" 
*/}
{/* No va a imprimir porque no tiene ningun valor asignado, tira error de compilacion
    int var1;
    Console.WriteLine(var1);*/
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
