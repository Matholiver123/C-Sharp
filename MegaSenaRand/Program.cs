using System;

namespace MatrizDezporDezRandNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixMegaSenaRand = new int[2, 3];
            Random rand = new Random();

            Console.Write("MEGA SENA - ETEC Belém \nA seguir os números gerados do sorteio: \n \n");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrixMegaSenaRand[i, j] = rand.Next(1,61); 
                    Console.Write(matrixMegaSenaRand[i, j] + "\t");
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
        }
    }
}