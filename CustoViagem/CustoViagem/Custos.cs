using System;
using System.Collections.Generic;
using System.Text;


namespace CustoViagem
{
    class Custos
    {
        // Atributos
        private double custoTotal;

        //Método Valor do pedágio 
        public void CalcularViagem(Percurso percurso)
        {
            
            custoTotal = (percurso.GetKmPercorrido() * percurso.GetValorCombustivel()) + percurso.GetValorPedagio();
        }

       
        public void SetValorPedagio(double custoTotal)
        {
            this.custoTotal = custoTotal;
        }
        public double GetCustoTotal()
        {
            return custoTotal;
        }
    }
}
