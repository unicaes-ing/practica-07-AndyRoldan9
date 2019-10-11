using System;
using System.Collections.Generic;
using System.Text;

namespace GUIA_PRACTICA_7
{
    class Ejercicio_4
    {
        public static int[,] matrix;

        public static void DatosMatriz()
        {
            matrix = new int[5, 5];
            Console.WriteLine("INGRESE LOS NUMEROS DE LA MATRIZ: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    string num;
                    num = Console.ReadLine();

                    matrix[i, j] = int.Parse(num);
                }
            }
        }

        public static void VerMatriz()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(matrix[i, j]);
                }
            }
        }

        static void Main(string[] args)
        {
            DatosMatriz();
            VerMatriz();
            Console.ReadKey();
        }
    }
}
