using System;


namespace Areas
{
    class Principal
    {
        static void Main(string[] args)
        {
            Quadrado q1 = new Quadrado();
            Console.WriteLine("Digite um lado para o quadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quadrado: " + q1.calcularArea(lado)); 

            Triangulo t1 = new Triangulo();
            Console.WriteLine("Digite a base para o triângulo: ");  
            double basee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite uma altura para o Triângulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Triângulo: " + t1.calculaArea(basee, altura)); 

            Circulo c1 = new Circulo();
            Console.WriteLine("Digite o raio para o círculo: ");  
            double raio = Convert.ToDouble(Console.ReadLine());  
            Console.WriteLine("Círculo: " + c1.calculaArea(raio)); 
        }
    }
}
