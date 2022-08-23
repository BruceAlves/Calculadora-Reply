using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Reply
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 10, valor2 = 200;


            ICalculadora calculo = new Calculadora(valor1, valor2);
            double resultadoMultiplicacao = calculo.Multiplicar();
            Console.Write($"O resultado da multiplicação {valor1} e {valor2} é {resultadoMultiplicacao}");


            double resultadoSoma = calculo.Somar();
            Console.WriteLine($"O resultado da soma {valor1} e {valor2} é {resultadoSoma}");



            double resultadoPorcentagem = calculo.Porcentagem();
            Console.WriteLine($"O resultado da porcentagem de {valor1} e {valor2} é {resultadoPorcentagem}%");

        }
    }
}
