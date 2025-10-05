internal class Program
{
    private static void Main(string[] args)
    {
        //Ejercicio 1 
        /*Confeccionar un programa que lea n pares de datos, cada par de datos corresponde
         * a la medida de la base y la altura de un triángulo. El programa deberá informar:
a) De cada triángulo la medida de su base, su altura y su superficie.
b) La cantidad de triángulos cuya superficie es mayor a 12.*/


        /*    int cantidadTaIngresar,contador=0;
            double alturaTriangulo, baseTriangulo, superficie;
            Console.WriteLine("Ingrese la cantidad de triángulos a cargar");
            cantidadTaIngresar = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < cantidadTaIngresar; i++)
            {
                Console.WriteLine("Ingrese la base del "+(i+1)+"° triángulo");
                baseTriangulo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingrese la altura del " + (i + 1) + "° triángulo");
                alturaTriangulo = Convert.ToDouble(Console.ReadLine());
                superficie = (baseTriangulo * alturaTriangulo )/ 2;
                Console.WriteLine("Altura del triángulo: "+alturaTriangulo);
                Console.WriteLine("Base del triángulo: " + baseTriangulo);
                Console.WriteLine("Superficie del triángulo: " + superficie);
                if (superficie > 12)
                {
                    contador++;
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Cantidad de triangulos con superficie mayor a 12: " + contador);
            Console.ReadKey();  */

        //Ejercicio 2
        /*Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados.*/

        /* int numero, suma=0;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese el " + (i + 1) + "° numero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (i >= 4)
            {
                suma = suma + numero;
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
        Console.WriteLine("La suma de los ultimos 5 números ingresados da como resultado: "+suma);
        Console.ReadKey(); */


        //Ejercicio 3
        /*Confeccionar un programa que permita ingresar un valor
         * del 1 al 10 y nos muestre la tabla de multiplicar del mismo (los primeros 13 términos).
Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.*/

      /*  int numero;
        Console.WriteLine("Ingrese el numero (1-10) para ver su tabla de multiplicar: ");
        numero = Convert.ToInt32(Console.ReadLine());
        while (numero > 10 || numero<1)
        {
            Console.WriteLine("Ingrese un numero válido(1-10) : ");
            numero = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("");
        for(int i = 1; i < 40; i++)
        {
            Console.WriteLine(Convert.ToString(numero)+"x"+Convert.ToString(i)+": " + (numero * i));
            Console.WriteLine("");
        }
        Console.ReadKey(); */
    }
}