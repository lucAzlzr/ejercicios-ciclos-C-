using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite 20 números y luego emitir 
            //por pantalla el máximo de los números pares y el mínimo de los números impares.
            int n, max = 0, min = 0;
            bool banPar = false, banImpar = false;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                if(n % 2 == 0){
                    if(banPar == false){
                        max = n;
                        banPar = true;
                    }else if(n > max)
                        max = n;
                }else if(banImpar == false){
                    min = n;
                    banImpar = true;
                }else if(n < min)
                    min = n;
            }
            Console.WriteLine("El máximo de los numeros pares es " + max + " y el mínimo de los números impares es " + min);
        }
    }
}
