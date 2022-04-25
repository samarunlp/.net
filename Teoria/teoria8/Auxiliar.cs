namespace Teoria8;
class Auxiliar{
    public void Procesar()
    {
       /* 
        FuncionEntera f;
        f = SumaUno;
        Console.WriteLine(f(10));
        f = SumaDos;
        Console.WriteLine(f(10));
        */
        int [] v = new int [] {11,5,90};
        //int externa= 7;
       /* FuncionEntera f= delegate(int n){
            return n * 2;
            //return n * 2 + externa; se puede hacer la suma con variables externas a la funcion
        };       
        //Aplicar(v, SumaDos); se cambia por la linea de abajo
        //Aplicar(v, f);
        Aplicar(v, n => n *2);
        Imprimir(v);
        //Aplicar(v,SumaUno); se utliza la nueva funcion "FuncionEntera"
        //Aplicar(v, delegate(int n) { return n + 10;});// metodo anonimo, recibe y devuelve un entero
        Aplicar(v, n => n +10);//En si mismo es un metodo
        Imprimir(v);*/
        Action a; //podria interpretarse como una lista de delegados que van un metodo al cual pueden invocar
        a= Metodo1;
        a=a + Metodo2;
        a += () =>Console.WriteLine("Expresion lambda");
        //a();
        a -= Metodo2;
        a?.Invoke();
       /*forma de accder uno por uno
       Delegate [] encolados = a.GetInvocationList(); //arreglo generico de Delegate
       for (int i = encolados.Length -1; i >= 0; i--) 
       {
          (encolados[i] as Action)?.Invoke();// los invoca en sentido inverso
       }*/
    }
    //int SumaUno(int n) => n+1;
    //int SumaDos(int n) => n+2;
     public void Metodo1()
    =>Console.WriteLine("Ejecutando Método1");
    public void Metodo2()
       =>Console.WriteLine("Ejecutando Método2");
    

    void Aplicar(int [] v, FuncionEntera f)
    {
        //utliza el for porque se esta modificando
        for (int i = 0; i < v.Length; i ++)
        {
            v [i] = f(v[i]);
        }
    }

    void Imprimir(int [] v)
    {
        foreach (int i in v)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();// la consola no imprime hasta que no encuentra un fin de linea (apretando la consola interna f5, con dotnet run funciona sin el console)
    }
}
