class Program
{
    static void Main(string[] args)
    {
       // ImprimirA();
  /*Queremos que las A se sincronice, no tener que esperar que se ejecute las A para que se ejecuten los
    guiones, para eso agregamos la linea 8 y 9. Se hace de manera asincronica (concurrente, la realiza el Main), pero no 
    se garantiza que se va a terminar porque uno puede agarrarlo mucho tiempo o va a ir más lento uno*/
        Task t = PrintAsync(); si le pongo t2 no pasa nada
        //Task t = Print(); //se agrega para llamar al static Task
        //Task t = new Task(ImprimirA);
        //t.Start();
        for( int i = 1; i <= 1000; i++)
        {
            Console.Write("-");
        } 
        //Console.WriteLine();//Console.WriteLine(" FIN");
       Console.Write($"\n Tiempo transcurrido: {t.Result} \n");
       // t.Wait(); //se pone para ejecutar todo, los 1000 . Si uso el asyn no uso wait porque tengo el await
    }

    //static Task Print() //metodo corto, una vez que finaliza le devuelve el control a Main
    //static Task PrintAsync() 
    //static async Task PrintAsync()//retorta un Task pero no puede retornar ninguna tarea. No retorna l sino una tarea nueva 
    static async Task<double> PrintAsync()  
    {
        Task t = new Task(ImprimirA); //Arranca a imprimir
        DateTime inicio = DateTime.Now;
        t.Start(); //ejecuta y escribe, no espera que termine 
        await t; //espera asincronica de t, devuelve el control cuando termina la tarea t para que siga el flujo de control(permite la intercalacción de los guinones y las A)
       // t.Wait(); //se hizo sincronico, se hizo secuencial. Es una espera sincronica, no le devuelve el comando antes al main, termina de ejecutar t y ahi lo devuelve.
         // double mlseg= (DateTime.Now - inicio).TotalMilliseconds; //el tiempo que tardan de ejecutarse todo el metodo
         // Console.Write($"\n Tiempo transcurrido: {mlseg} \n");
       // return t;
       return (DateTime.Now - inicio).TotalMilliseconds; //modificamos para que retorne ese double
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


