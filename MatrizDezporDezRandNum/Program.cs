using System;

namespace MatrizDezporDezRandNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixrRand = new int[10, 10];

            Random rand = new Random();


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrixrRand[i, j] = rand.Next(100);
                };
            };

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matrixrRand[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }   
    }
}
