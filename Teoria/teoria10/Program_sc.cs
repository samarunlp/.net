class Program
{
    static void Main(string[] args)
    {
        Task<double> t= PrintAsync();
        for( int i = 1; i <= 1000; i++)
        {
            Console.Write("-");
        } 
        Console.Write($"\n Tiempo transcurrido: {t.Result} \n");
    }
    static async Task<double> PrintAsync() 
    {
        Task t = new Task(ImprimirA); 
        DateTime inicio = DateTime.Now;
        t.Start(); 
        await t;
        return (DateTime.Now - inicio).TotalMilliseconds;
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

