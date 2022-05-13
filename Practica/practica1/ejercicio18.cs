/*
18. ¿Cuál es la salida por consola del siguiente código?
for (int i = 0; i <= 4; i++)
{
string st = i < 3 ? i == 2 ? "dos" : i == 1 ? "uno" : "< 1" : i < 4 ? "tres" : "> 3";
Console.WriteLine(st);
}
*/

//Es lo mismo que escribir
            for (int i = 0; i <= 4; i++){
                if (i < 3){
                    if (i == 2){
                        Console.WriteLine("dos");
                    }else if (i == 1){
                        Console.WriteLine("uno");
                    }else{
                        Console.WriteLine("< 1");
                    }
                }else{
                        if (i < 4){
                            Console.WriteLine("tres");
                        }else{
                            Console.WriteLine("> 3");
                        }
                    }
            }
            Console.ReadLine();
        }

/*
IMPRIME
< 1  
uno //Cuando el i llega a 1
dos //Cuando el i llega a 2
tres //Cuando el i llega a 3
> 3 
*/
