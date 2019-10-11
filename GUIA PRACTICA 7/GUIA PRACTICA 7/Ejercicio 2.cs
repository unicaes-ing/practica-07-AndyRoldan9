using System;
using System.Collections.Generic;
using System.Text;

namespace GUIA_PRACTICA_7
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            int numPar = 0;
            int numInPar = 0;
            int cantNumeros = 0;
            Console.WriteLine("CUANTOS NUMERO DESEAS ESCRIBIR??");
            cantNumeros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] numeros = new int[cantNumeros];
            for (int i = 0; i < cantNumeros; i++)
            {
                Console.WriteLine("INGRESA EL  VALOS DE NUMERO: " + i);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                if (numeros[i] % 2 == 0)
                {
                    numPar = numPar + 1;
                }
                else
                {
                    numInPar = numInPar = 1;
                }
            }
            Console.WriteLine("LA CANTIDAD DE NUMEROS PARES SON: " + numPar);
            Console.WriteLine("LA CANTIDAD DE NUMEROS IMPARES SON: " + numInPar);
            Console.ReadKey();
        }

    }
}
