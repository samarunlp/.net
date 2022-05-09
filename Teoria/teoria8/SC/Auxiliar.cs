namespace Teoria8;
class Auxiliar{
    public void Procesar()
    {
        Action a;
        a = Metodo1;
        a = a + Metodo2;
        a += () => Console.WriteLine("Expresión lambda");
        a -= Metodo2;
        a?.Invoke();
    }

    public void Metodo1()
    =>Console.WriteLine("Ejecutando Método1");
    public void Metodo2()
       =>Console.WriteLine("Ejecutando Método2");
    
    void Aplicar(int [] v, FuncionEntera f)
    {
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
        Console.WriteLine();
    }
}
