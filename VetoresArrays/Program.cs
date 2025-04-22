using System;

namespace VetoresArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //criando um array de 4 elementos
            string[] carro = new string[4];

            // declaração de arrays/vetores
            string[] carros = { "Volvo", "BMW", "Ferrari", "Volkswagem" };
            int [] meusNumeros = { 10, 20, 30, 40 };

            // imprime o valor de carro
            Console.WriteLine(carros[0]);

            //Imprimir o número 30 do array meuNumeros
            Console.WriteLine(meusNumeros [2]);

            //modificação de array/vetores
            carros[0] = "Volkswagem";
            Console.WriteLine(carros[0]);

            //Imprime o comprimento de ambos os arrays  
            Console.WriteLine(carros.Length); //3
            Console.WriteLine(meusNumeros.Length); //4
            
            //códigos da lousa passada
            //criando um array de 4 elementos
            string[] carro = new string[4];
 
            //criando um array de 4 elementos e adiconando valores
            string[] carros = { "Volvo", "BMW", "Ferrari", "Volkswagem" };
 
            // criando um array de 4 elementos sem especificar tamanho
            string[] carro2 = new string[] { "Volvo", "BMW", "Ferrari", "Volkswagem" };
 
            //criando um array de 4 elementos omitindo a palavra new sem especificar o tamanho
            string[] carro3 = { "Volvo", "BMW", "Ferrari", "Volkswagem" };
            Console.WriteLine(carros.Length); //4
            */

            string[] carros = { "Volvo", "BMW", "Ferrari", "Volkswagem", "Ford" };
            /*
            for (int i = 0; i < carros.Length; i++)
            {
                Console.WriteLine(carros[i]);
            }
            */
            //ordenado uma string
            Array.Sort(carros);

            // loops
            
            foreach (string i in carros)
            {
                Console.WriteLine(i);
            }
           
        }
        }
    }

 
