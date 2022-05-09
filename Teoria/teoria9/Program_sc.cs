class Program
{
    static void Main (string [] args) 
    {
        int a =17; 
        int b= 23;
        Swap<int>(ref a, ref b);//Swap<int>(ref a, ref b); SearchOption invoca Swap<int> deduce
        Console.WriteLine($"a={a} y b={b}");
        string st1= "hola";  
        string st2 = "mundo";
        Swap<string>(ref st1, ref st2);
        Console.WriteLine($"st1={st1} y st2={st2}");
        
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
