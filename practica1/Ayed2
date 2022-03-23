package practica1;

import java.util.Scanner;

/*
 2. Escriba un método de clase que dado un número n devuelva un nuevo arreglo de
tamaño n con los n primeros múltiplos enteros de n mayores o iguales que 1.
Ejemplo: f(5) = [5; 10; 15; 20; 25]; f(k) = {nk/k : 1..k}
Agregue al programa la posibilidad de probar con distintos valores de n
ingresándolos por teclado, mediante el uso de System.in. La clase Scanner permite
leer de forma sencilla valores de entrada.
 */
public class Ejercicio2 {
	public static int[] NewArreglo(int n) {
		int vector[]= new int[n];
		for (int i=1; i<n;i++) {
			vector[i]=n*i;
		}
		return vector;
		
	}	
	public static void main(String[] args) {
	  try (Scanner s = new Scanner(System.in)) {
	  
	  System.out.println("Ingrese tamaño del arreglo");
	  int a= s.nextInt();
	  int vector[]= NewArreglo(a);
	  System.out.println("Imprimo arreglo");
	  for(int i=0;i< a; i++) {
		  System.out.println(vector[i]);
	  }
	  System.out.println("");
   }
	}
}
