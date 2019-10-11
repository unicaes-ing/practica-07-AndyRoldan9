using System;
using System.Collections.Generic;
using System.Text;

namespace GUIA_PRACTICA_7
{
    class Ejercicio_3
    {
        public static String[][] datos;
        

        public static void Equipo()
        {
            int grupos, integrantes;
            Console.WriteLine("CUANTOS EQUIPOS DESEAS CREAR:");
            grupos = Convert.ToInt32(Console.ReadLine());
            datos = new String[grupos][];
            for (int g = 0; g < datos.Length; g++)
            {
                Console.WriteLine();
                Console.WriteLine("CUANTOS INTEGRANTES TIENE EL EQUIPO "+(g+1)+":");
                integrantes = Convert.ToInt32(Console.ReadLine());
                datos[g] = new String[integrantes];
                for (int i = 0; i < datos[g].Length; i++)
                {
                    Console.WriteLine("INGRESE EL NOMBRE DEL INTEGRANTE "+(i+1)+":");
                    datos[g][i] = Console.ReadLine();
                }
            }

        }
        public static void DatosEquipo()
        {
            Console.WriteLine();
            Console.WriteLine("LA INFORMACION DE LOS EQUIPOS:");
            for (int g = 0; g < datos.Length; g++)
            {
                Console.WriteLine("EQUIPO "+(g+1)+": ");
                for (int i = 0; i < datos[g].Length; i++)
                {
                    Console.WriteLine(datos[g][i]+" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Equipo();
            Console.ReadKey();
            DatosEquipo();
            Console.ReadKey();
        }
    }

}
