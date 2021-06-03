using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraSimples {
    class Calculadora {
        private double resultadoCalculo;

        public double CalculoSoma(double primeiroNumero, double segundoNumero) {
            resultadoCalculo = primeiroNumero + segundoNumero;
            return resultadoCalculo;
        }

        public double CalculoSubtracao(double primeiroNumero, double segundoNumero) {
            resultadoCalculo = primeiroNumero - segundoNumero;
            return resultadoCalculo;
        }

        public double CalculoMultiplicacao(double primeiroNumero, double segundoNumero) {
            resultadoCalculo = primeiroNumero * segundoNumero;
            return resultadoCalculo;
        }

        public double CalculoDivisao(double primeiroNumero, double segundoNumero) {
            resultadoCalculo = primeiroNumero / segundoNumero;
            return resultadoCalculo;
        }

    }
}
