using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente1
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string NumeroConta { get; set; }
        public double Saldo { get; protected set; }

        public Pessoa(string nome, string numeroConta, double saldoInicial)
        {
            Nome = nome;
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo de {Nome}: R$ {Saldo:F2}");
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado.");
            }
            else
            {
                Console.WriteLine("Valor inválido para depósito.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado.");
            }
            else
            {
                Console.WriteLine("Saque inválido ou saldo insuficiente.");
            }
        }
    }

}
