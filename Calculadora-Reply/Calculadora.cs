using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Reply
{
    public class Calculadora
    {
        public Calculadora(double n1, double n2)
        {
            this.N1 = n1;
            this.N2 = n2;
        }

        public double N1 { get; private set; }
        public double N2 { get; private set; }


        private double Resultado { get; set; }

        public double Somar()
        {
            if (N1 < 0 || N2 < 0)
            {
                throw new Exception("Operação permitida somente com numeros positivos");
            }


            Resultado = N1 + N2;
            return Resultado;

        }

        public double Multiplicar()
        {
            if (N2 < 0)
            {
                throw new Exception(" O segundo numero deve ser  positivo");
            }

            Resultado = N1 * N2;
            return Resultado;
        }


        public double Porcentagem()
        {
            Resultado = N1 / N2;

            return Resultado;
        }


    }
}
