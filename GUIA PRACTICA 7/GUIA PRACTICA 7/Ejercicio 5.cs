using System;
using System.Collections.Generic;
using System.Text;

namespace GUIA_PRACTICA_7
{
    class Ejercicio_5
    {
        public static int[,] Matrix1;

        public static int[,] Matrix2;

        static int Suma(int[,] matriz1)
        {
            int sum = 0;
            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    sum = matriz1[i, j];
                }
            }
            return sum;
        }

        static int suma2(int[,] matriz2)
        {
            int sum = 0;
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    sum = matriz2[i, j];
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int total = 0;
            Matrix1 = new int[3, 3];
            Console.WriteLine("INGRESE LOS NUMEROS DE LA PRIMERA MATRIZ ");
            for (int i = 0; i < Matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix1.GetLength(1); j++)
                {
                    string num;
                    num = Console.ReadLine();
                    Matrix1[i, j] = int.Parse(num);
                }
            }
            Console.Clear();
            Matrix2 = new int[3, 3];
            Console.WriteLine("INGRESA LOS NUMEROS DE LA SEGUNDA MATRIZ ");
            for (int i = 0; i < Matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix2.GetLength(1); j++)
                {
                    string num;
                    num = Console.ReadLine();
                    Matrix2[i, j] = int.Parse(num);
                }
            }
            Console.Clear();
            total = Suma(Matrix1) + suma2(Matrix2);
            Console.WriteLine("SUMA DE LAS MATRICES: {0:N0}", total);
            Console.ReadKey();
        }
    }
}
