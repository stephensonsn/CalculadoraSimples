using System;

namespace CalculadoraSimples {
    class Program {
        static void Main(string[] args) {
            //2 * (lagura + profundidade) * altura
            Console.WriteLine("Digite o primeiro número: ");
            double primeiroNumero = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double segundoNumero = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual tipo de operação deseja fazer?");
            Console.WriteLine("[1] = Soma");
            Console.WriteLine("[2] = Subtração");
            Console.WriteLine("[3] = Multiplicação");
            Console.WriteLine("[4] = Divisão");

            Calculadora calculadora = new Calculadora();

            switch(Console.ReadLine()) {
                case "1":
                    Console.WriteLine("O resultado do seu calculo é: ");
                    Console.WriteLine(calculadora.CalculoSoma(primeiroNumero, segundoNumero));
                    break;
                case "2":
                    Console.WriteLine("O resultado do seu calculo é: ");
                    Console.WriteLine(calculadora.CalculoSubtracao(primeiroNumero, segundoNumero));
                    break;
                case "3":
                    Console.WriteLine("O resultado do seu calculo é: ");
                    Console.WriteLine(calculadora.CalculoMultiplicacao(primeiroNumero, segundoNumero));
                    break;
                case "4":
                    Console.WriteLine("O resultado do seu calculo é: ");
                    Console.WriteLine(calculadora.CalculoDivisao(primeiroNumero, segundoNumero));
                    break;
            }

            Console.ReadLine();
        }
    }
}
