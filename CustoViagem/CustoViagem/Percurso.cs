using System;
using System.Collections.Generic;
using System.Text;


namespace CustoViagem
{
    class Percurso
    {
        // atributos
        private double kmPercorrido;
        private double valorCumbutivel;
        private double valorPedagio;

        // Getter's e Setter's
        public void SetKmPercorrido(double kmPercorrido)
        {
            this.kmPercorrido = kmPercorrido;
        }
        public double GetKmPercorrido()
        {
            return kmPercorrido;
        }

        public void SetValorCombustivel(double valorCombustivel)
        {
            this.valorCumbutivel = valorCombustivel;
        }
        public double GetValorCombustivel()
        {
            return valorCumbutivel;
        }

        public void SetValorPedagio(double valorPedagio)
        {
            this.valorPedagio = valorPedagio;
        }
        public double GetValorPedagio()
        {
            return valorPedagio;
        }

        // Método para cadastrar o percurso
        public void CadastrarPercurso(double kmPercorrido, double valorCombustivel, double valorPedagio)
        {
            SetKmPercorrido(kmPercorrido);
            SetValorCombustivel(valorCombustivel);
            SetValorPedagio(valorPedagio);
        }

        // Método do percurso percorrido
        public string ListaPercurso()
        {
            return $"Km Percorrido: {kmPercorrido}, Valor Combustível: {valorCumbutivel}, Valor Pedágio: {valorPedagio}";
        }
    }
}
