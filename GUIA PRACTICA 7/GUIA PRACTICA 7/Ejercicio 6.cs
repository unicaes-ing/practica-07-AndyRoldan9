using System;
using System.Collections.Generic;
using System.Text;

namespace GUIA_PRACTICA_7
{
    class Ejercicio_6
    {
        public static Random r;

        public static int[,] num;

        public static void setDate()
        {
            r = new Random();
            num = new int[10, 10];
            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    num[i, j] = r.Next(10, 99);
                }
            }
            Console.WriteLine("SE HA GENERADO UNA MATRIZ:)");
            Console.WriteLine("PRESS  ANY KEY FOR RETUR MENU");
            Console.ReadLine();
        }

        public static void GetDate()
        {
            Console.WriteLine("______________________________________________");
            for (int i = 0; i < num.GetLength(0); i++)
            {
                Console.WriteLine("/");
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    if (num[i, j] == 0)
                    {
                        Console.WriteLine("00");
                    }
                    else
                    {
                        if ((num[i, j] != 0) && (num[i, j] % 2 == 0))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.WriteLine(num[i, j]);
                    }
                    
                    Console.WriteLine("/");
                }
                if (i < 9)
                {
                    Console.WriteLine("_____________________________________________________");
                }
                Console.WriteLine("=====================================================");
                Console.WriteLine("PRESS  ANY KEY FOR RETUR MENU");
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            int opc = 0;
            num = new int[6, 6];
            do
            {
                Console.Clear();
                Console.WriteLine("QUE DESEAS HACER");
                Console.WriteLine();
                Console.WriteLine("[1]---------FORMAR UNA MATRIZ");
                Console.WriteLine();
                Console.WriteLine("[2]---------VER LA MATRIZ");
                Console.WriteLine();
                Console.WriteLine("[3]---------SALIR DEL PROGRAMA");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        setDate();
                        break;
                    case 2:
                        GetDate();
                        break;
                }
            } while (opc != 3);
        }
    }
}
