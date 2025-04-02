using System;


namespace CustoViagem
{
    class Principal
    {
        static void Main(string[] args)
        {
            // Método Construtor
            Percurso p1 = new Percurso();
            Console.WriteLine("Digite a Distancia Percorrida: ");
            double kmPercorrido = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do litro do Cumbutivel: ");
            double valorCumbutivel = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do Pedagio: ");
            double valorPedagio = Convert.ToDouble(Console.ReadLine());
            p1.CadastrarPercurso(kmPercorrido, valorCumbutivel, valorPedagio);
            Console.WriteLine("Percurso: " + p1.ListaPercurso());

            // Método Construtor
            Custos c1 = new Custos();
            c1.CalcularViagem(p1);
            Console.WriteLine("Custo Total da Viagem: " + c1.GetCustoTotal());
        }
    }
}
