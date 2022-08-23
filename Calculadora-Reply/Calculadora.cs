using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Reply
{
    public class Calculadora : ICalculadora
    {
        public Calculadora(double valor1, double valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;
        }

        public double Valor1 { get; private set; }
        public double Valor2 { get; private set; }


        private double Resultado { get; set; }

        public double Somar()
        {
            if (Valor1 < 0 || Valor2 < 0)
            {
                throw new Exception("Operação permitida somente com numeros positivos");
            }


            Resultado = Valor1 + Valor2;
            return Resultado;

        }

        public double Multiplicar()
        {
            if (Valor1 < 0)
            {
                throw new Exception(" O segundo numero deve ser  positivo");
            }

            Resultado = Valor1 * Valor2;
            return Resultado;
        }


        public double Porcentagem()
        {
          
            Resultado = (100.0 / Valor2) * Valor1;

            return Resultado;
        }


    }
}
