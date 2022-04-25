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
        Aplicar(v, SumaDos);
        Imprimir(v);
        Aplicar(v,SumaUno);
        Imprimir(v);
    }
    int SumaUno(int n) => n+1;
    int SumaDos(int n) => n+2;

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
