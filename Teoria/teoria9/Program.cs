class Program
{
    static void Main (string [] args) //vale tener un main "static void Main()" sin argumentos
    {
        //Primer ejemplo
        
        /*Primera solucion
        int a =17;
        int b= 23;
        Swap(ref a, ref b);
        a= (int)o1; b= (int) o2;//boxing
        Console.WriteLine($"a={a} y b={b}");
        //sobrecarga del metodo swap
        string st1= "hola";  string st2 = "mundo";
        Swap(ref st1, ref st2);
        Console.WriteLine($"st1={st1} y st2={st2}");
        */
         /*Segunda solucion
        object o1,o2;
        int a =17;
        int b= 23;
        o1=a; o2=b; //variables auxiliares para que ande swap
        Swap(ref o1, ref o2);//Swap(ref a, ref b);
        a= (int)o1; b= (int) o2;//boxing
        Console.WriteLine($"a={a} y b={b}");
        //sobrecarga del metodo swap
        string st1= "hola";  string st2 = "mundo";
        o1=st1;o2=st2;//unboxing
        Swap(ref o1, ref o2);//Swap(ref st1, ref st2);
        st1=(string)o1; st2= (string)o2;
        Console.WriteLine($"st1={st1} y st2={st2}");
        */
       /*Tercera solucion
        Al usarlo se pierden muchos chequeos y controles de seguridad; y realiza boxing por ej en b=17. No es buena solucion, la sobrecarga es "mejor"
        dynamic a =17; 
        dynamic b= 23;
        Swap(ref a, ref b);
        Console.WriteLine($"a={a} y b={b}");
        dynamic st1= "hola";  
        dynamic st2 = "mundo";
        Swap(ref st1, ref st2);
        Console.WriteLine($"st1={st1} y st2={st2}");
    }*/

//Para mejorar esto se utilizan los metodos genericos
        //Cuarta solucion-->Eficiente 
        int a =17; 
        int b= 23;
        Swap<int>(ref a, ref b);//Swap<int>(ref a, ref b); SearchOption invoca Swap<int> deduce
        Console.WriteLine($"a={a} y b={b}");
        string st1= "hola";  
        string st2 = "mundo";
        Swap<string>(ref st1, ref st2);
        Console.WriteLine($"st1={st1} y st2={st2}");
/*sobrecarga del metodo swap
     static void Swap(ref int a, ref int b){
         int x=a;
         a=b;
         b=x;
     }
     static void Swap(ref string st1, ref string st2){
         string aux=st1;
         st1=st2;
         st2=aux;
     }*/

/*Si quiero usar esto, los parametros estan "mal" porque espera un entero o un string
     static void Swap(ref object i, ref object j){
         object aux=i;
         i=j;
         j=aux;
     }*/
    //metodo swap generico    
     static void Swap <T>(ref T i, ref T j){
         T aux=i; //no es un tipo real
         i=j;
         j=aux;
     }
        
        
     //Segundo ejemplo
     int i = (int) Maximo(100,5);//unboxing
     Console.WriteLine(i);
     string st= (String)Maximo("hola", "mundo");
     Console.WriteLine(st);
     Console.WriteLine(Maximo('A','B'));

     /*static IComparable Maximo(IComparable a, IComparable b)
     {
         if(a.CompareTo(b)>0){
             return a;
         }
         return b;
     }*/
   //meotodo generico
     static T Maximo<T>(T a, T b) where T:IComparable //se utliza esto para poder solucionar el problema de CompareTo
     {
         if(a.CompareTo(b)>0){//el compilador no sabe si esta definido el CompareTo en el tipo T
             return a;
         }
         return b;
     }
    }
}
        
}
