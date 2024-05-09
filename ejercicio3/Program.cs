using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
            int edad, promedio, acu = 0, contador = 0;

            for (int x = 0; x < 8; x++)
            {
                Console.WriteLine("Ingrese una edad:");
                edad = int.Parse(Console.ReadLine());
                if(edad > 18){
                    acu += edad;
                    contador++;
                    }
            }
            promedio = acu / contador;
            Console.WriteLine("El promedio de edad de las personas mayores a 18 años es: " + promedio);


        }
    }
}
