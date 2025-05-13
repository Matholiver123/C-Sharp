using System;
using System.Collections.Generic;
using System.Text;

namespace CorrecaoArrayMultidimensional
{
    class Princiapal
    {
        static void Main(string[] args)
        {
            int colunas = 5;
            int linhas = 5;
            int[,] numeros = new int[colunas, linhas];

            int numeroPar = 2;


            for (int i = 0; i < colunas; i++) 
            {
                for (int j = 0; j < linhas; j++)
                {
                    numeros[i, j] = numeroPar;
                    numeroPar += 2;
                };
            };

            for (int i = 0; i < colunas; i++)
            {
                for (int j = 0; j < linhas; j++)
                {
                    Console.Write(numeros[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
