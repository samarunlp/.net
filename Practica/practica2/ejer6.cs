/*Determinar qué hace el siguiente programa y explicar qué sucede si no se pasan parámetros
cuando se invoca desde la línea de comandos.*/

Console.WriteLine("¡Hola {0}!", args[0]);

//El programa espera recibir un parametro que luego reemplaza en "{0}"
//si usamos launch.json y en donde dice "args:[]" le modifico por "args:["uno"]" se imprimira ¡Hola uno! , es decir, el parametro que le envie.
//si no le manda ningun parametro la consola se cierra y no muestra nada.
