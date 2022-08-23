/*3. Analizar la siguiente porción de código para calcular la sumatoria de 1 a 10. ¿Cuál es el error?
¿Qué hace realmente?*/
int sum = 0;
int i = 1;
while (i <= 10);
{
sum += i++;
}

/*
Después del parentesis del while no va el ";" porque se queda en un bucle infito
*/
