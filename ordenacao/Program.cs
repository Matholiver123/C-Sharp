using System;

namespace ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, 1, 8, 9 };

            Array.Sort(numeros);

            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}