using System;

namespace GUIA_PRACTICA_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantPersonas;
            int menores = 0;
            int mayores = 0;
            Console.WriteLine("CUANTAS PERSONAS SON??");
            cantPersonas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] edades = new int[cantPersonas];
            for (int i = 0; i < cantPersonas; i++)
            {
                Console.WriteLine("INGRESA LA EDAD DE LA PERSONA " + i);
                edades[i] = Convert.ToInt32(Console.ReadLine());
                if (edades[i] < 18)
                {
                    menores = menores + 1;
                }
                else
                {
                    if (edades[i] >= 18)
                    {
                        mayores = mayores + 1;
                    }
                }

            }
            Console.WriteLine("LA CANTIDAD DE PERSONAS MAYORES SON: " + menores);
            Console.WriteLine("LA CANTIDAD DE PERSONAS MAYORES SON: " + mayores);
            Console.ReadKey();

        }
    }

}
