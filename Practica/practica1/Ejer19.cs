/*
19. Para cada una de las siguientes líneas de código verificar cuáles son permitidas por el
compilador y en tal caso en qué estado quedan las variables involucradas en la declaración al
ejecutarse:
int a, b, c;
int a; int b; int c, d;
int a = 1; int b = 2; int c = 3;
int b; int c; int a = b = c = 1;
int c; int a, b = c = 1;
int c; int a = 2, b = c = 1;
int a = 2, b, c, d = 2 * a;
int a = 2, int b = 3, int c = 4;
int a = 2; b = 3; c = 4;
int a; int c = a;
char c = 'A', string st = "Hola";
char c = 'A'; string st = "Hola";
char c = 'A', st = "Hola";
*/
