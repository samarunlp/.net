/*
Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos
implementados en el ejercicio anterior.

El módulo datetime proporciona clases para manipular fechas y horas. Si bien la implementación permite operaciones aritméticas con fechas y horas, 
su principal objetivo es poder extraer campos de forma eficiente para su posterior manipulación o formateo.


// Inicia el contador:
DateTime tiempo1 = DateTime.Now;
 
// Código del programa...
 
// Para el contador e imprime el resultado:
DateTime tiempo2 = DateTime.Now;
TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
Console.Write( "TIEMPO: " + total.ToString() );

*/
