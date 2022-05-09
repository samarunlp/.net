//VER QUE IMPLIME
Console.WriteLine("Primer ejemplo");
object obj= 7.3;//obj apunta a un valor de tipo double
Console.WriteLine(obj.GetType());
obj="Casa";//ahora de tipo string
Console.WriteLine(obj.GetType());
oBj=4;//ahora de tipo int
Console.WriteLine(obj.GetType());


//SABE IMPRIMIR OBJETOS DE CUALQUIER TIPO
{
Console.WriteLine("Segundo ejemplo");
object obj= 7.3;
Console.WriteLine(obj);
obj="Casa";
Console.WriteLine(obj);
obj=4;
Console.WriteLine(obj);
Console.WriteLine((int)obj + 1);
}

//SOBRECARGAS-->Esta en las diapositivas
{
Console.WriteLine("Tercer ejemplo");
    object obj= 1+ 2.3;
    Console.WriteLine(obj.GetType());
    Console.WriteLine(obj);
}
{
Console.WriteLine("Cuarto ejemplo");
    object obj= 1 + 'A'; 
    Console.WriteLine(obj.GetType());  
    Console.WriteLine(obj);
}
{
Console.WriteLine("Quinto ejemplo");
    object obj= "CAS" + 'A';
    Console.WriteLine(obj.GetType());
    Console.WriteLine(obj); 
}
{
Console.WriteLine("Sexto ejemplo");
    object obj= "Área" + 51;
    Console.WriteLine(obj.GetType()); 
    Console.WriteLine(obj);
*/}
{
Console.WriteLine("Septimo ejemplo");
    //El + ejecuta de izq a derecha
    object obj= "Área" + 5 + 1;
    Console.WriteLine(obj.GetType()); 
    Console.WriteLine(obj); 
*/}
{
Console.WriteLine("Octavo ejemplo");
    //El + ejecuta de izq a derecha
    object obj= 5 + 1 + "Área" ;
    Console.WriteLine(obj.GetType()); 
    Console.WriteLine(obj);
}
{
Console.WriteLine("Noveno ejemplo");
    int? i1=null;
    string? st1=null; 
    int i2=null; 
    string st2=null;
}
{/* No va a imprimir porque no tiene ningun valor asignado, tira error de compilacion
    int var1;
    Console.WriteLine(var1);*/
}
//MISMOS EJEMPLOS, UNO DA FALSO Y EL OTRO VERDADERO(LA SEGUNDA VEZ QUE IMPRIME)
//VERDADERO, FALSO
{
Console.WriteLine("Decimo ejemplo");
    char c1='A';
    char c2= 'A';
    Console.WriteLine(c1==c2);//True porque compara los contenidos 
    object o1= 'A';
    object o2= 'A'; 
    Console.WriteLine(o1==o2); 
}
//VERDADERO, VERDADERO
{
Console.WriteLine("Decimo primero ejemplo");
    char c1='A';
    char c2= c1;
    Console.WriteLine(c1==c2);//True 
    object o1= 'A';
    object o2= o1;  
    Console.WriteLine(o1==o2); //True (Apuntan al mismo objeto)
}
