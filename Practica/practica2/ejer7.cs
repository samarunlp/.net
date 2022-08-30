/*
7.Analizar el siguiente código. ¿Qué líneas producen error de compilación y por qué?
char c;
char? c2;
string? st;
c = ""; //quiere asignarle un string a un tipo char
c = ''; //
c = null; //es no nulable, por defecto tiene valores indefinidos no se le puede asignar null
c2 = null; /es no nulable, por defecto tiene valores indefinidos no se le puede asignar null por mas que tenga el signo
c2 = (65 as char?); //tira un warning porque char sera null
st = "";
st = ''; //para asignarle a un string "vacio" se hace con doble comillas
st = null; //tirara error porque antes se le puse el signo ?
st = (char)65; //no se puede convertir un char a string de esa manera
st = (string)65; no se puede convertir un intero a string de esa manera
st = 47.89.ToString(); 
*/
