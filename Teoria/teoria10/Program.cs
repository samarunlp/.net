class Program
{
    static void Main(string[] args)
    {
       // ImprimirA();
  /*Queremos que las A se sincronice, no tener que esperar que se ejecute las A para que se ejecuten los
    guiones, para eso agregamos la linea 8 y 9. Se hace de manera sincronica (concurrente), pero no 
    se garantiza que se va a terminar porque uno puede agarrarlo mucho tiempo o va a ir más lento uno*/
        Task t = new Task(ImprimirA);
        t.Start();
        for( int i = 1; i <= 1000; i++)
        {
            Console.Write("-");
        } 
        Console.WriteLine(" FIN");
    }

    static void ImprimirA()
    {
        for( int i = 1; i <= 1000; i++)
        {
            Console.Write("A");
        } 
        Console.WriteLine(" FIN");
    }
}


