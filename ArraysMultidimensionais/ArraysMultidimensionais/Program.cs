using System;

namespace ArraysMultidimensionais
{
    class Program
    {
        static void Main(String[] args)
        {
            int[,] numeros = { { 1, 4, 2 }, { 3, 6, 8 } };
            /*
            // Tridimensional (corrigido)
            int[,,] numeros1 = { { { 1, 4, 2 } }, { { 3, 6, 8 } } };


            /*
           Console.WriteLine(numeros[0, 2]);
           //saida 2

           numeros[0, 0] = 5;
           Console.WriteLine(numeros[0, 0]);
           //saída 5 ao invés de 1
           */

            int[,] numeros2 = new int[,] { { 1, 4, 2 }, { 3, 6, 8 } };

            foreach (int i in numeros2)
            {
                Console.WriteLine(i);
            }
            

        }
    }
}
