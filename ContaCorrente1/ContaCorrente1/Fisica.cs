using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente1
{
    public class Fisica : Pessoa
    {
        public string CPF { get; set; }

        public Fisica(string nome, string numeroConta, double saldoInicial, string cpf)
            : base(nome, numeroConta, saldoInicial)
        {
            CPF = cpf;
        }
    }

}
