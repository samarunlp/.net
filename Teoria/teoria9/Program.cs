class Program
{
    static void Main (string [] args) //vale tener un main "static void Main()" sin argumentos
    {
        /*
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
/*Al usarlo se pierden muchos chequeos y controles de seguridad; y realiza boxing por ej en b=17. No es buena solucion, la sobrecarga es "mejor"
        dynamic a =17; 
        dynamic b= 23;
        Swap(ref a, ref b);
        Console.WriteLine($"a={a} y b={b}");
        dynamic st1= "hola";  
        dynamic st2 = "mundo";
        Swap(ref st1, ref st2);
        Console.WriteLine($"st1={st1} y st2={st2}");
    }
Para mejorar esto se utilizan los metos genericos*/
/*//sobrecarga del metodo swap
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

//Si quiero usar esto, los parametros estan "mal" porque espera un entero o un string
     static void Swap(ref object i, ref object j){
         object aux=i;
         i=j;
         j=aux;
     }
}
