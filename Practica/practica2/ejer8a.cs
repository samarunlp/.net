/*
8. Escribir un programa que reciba una lista de nombres como parámetro e imprima por consola un
saludo personalizado para cada uno de ellos.
a) utilizando la sentencia for
*/

List<String> lista = new List<String> () {"Samar","Emanuel","Rocío"};
for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine("Hola "+lista[i]);
}
