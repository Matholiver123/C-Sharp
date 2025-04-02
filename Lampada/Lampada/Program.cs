using System;

namespace LampadaNamespace
{
    class Lampada
    {
        // Atributos
        public int lampadaNro;
        public string comodo;
        public bool status;

        // Método para provar a existência da lâmpada
        public void ProvarExistencia()
        {
            Console.WriteLine("Oi, eu existo!");
        }

        // Método para exibir o status da lâmpada
        public void ExibirStatus()
        {
            string estado = status ? "Ligada" : "Desligada";
            Console.WriteLine($"Lâmpada {lampadaNro} na {comodo} está {estado}.");
        }

        static void Main(string[] args)
        {
            // Criando a primeira instância (l1)
            Lampada l1 = new Lampada();
            l1.ProvarExistencia();

            // Inserindo dados no objeto l1
            l1.lampadaNro = 1;
            l1.comodo = "Sala";
            l1.status = false;

            // Exibindo dados do objeto l1
            Console.WriteLine(l1.lampadaNro);
            Console.WriteLine(l1.comodo);
            Console.WriteLine(l1.status);

            Console.WriteLine($"Número: {l1.lampadaNro}");
            Console.WriteLine($"Cômodo: {l1.comodo}");
            l1.ExibirStatus();

            // Criando a segunda instância (l2)
            Lampada l2 = new Lampada();
            l2.ProvarExistencia();

            // Inserindo dados no objeto l2
            l2.lampadaNro = 3;
            l2.comodo = "Quarto";
            l2.status = true;

            // Exibindo dados do objeto l2
            Console.WriteLine(l2.lampadaNro);
            Console.WriteLine(l2.comodo);
            Console.WriteLine(l2.status);

            Console.WriteLine($"Número: {l2.lampadaNro}");
            Console.WriteLine($"Cômodo: {l2.comodo}");
            l2.ExibirStatus();
        }
    }
}