using System;
using System.Collections.Generic;
using System.Text;

namespace ContaCorrente1
{
    public class Juridica : Pessoa
    {
        public string CNPJ { get; set; }

        public Juridica(string nome, string numeroConta, double saldoInicial, string cnpj)
            : base(nome, numeroConta, saldoInicial)
        {
            CNPJ = cnpj;
        }
    }

}
