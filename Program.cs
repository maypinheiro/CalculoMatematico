using System;
using System.Globalization;

namespace CalculadoraDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
            SelecionaOperacao();
        }
        static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Escolha um Opção");
            Console.WriteLine("1- Calculadora IMC");
            Console.WriteLine("2- Calculadora Area Circulo");
            Console.WriteLine("3- Calculadora regra de 3");
            Console.WriteLine("4- Sair");
            Console.WriteLine("------------------------------");
        }

        private static void SelecionaOperacao()
        {
            Calculos calculo = new Calculos();
            ValidaOperadores validarOperadores = new ValidaOperadores();

            int op = int.Parse(Console.ReadLine()) - 1;

            switch (op)
            {
                case (int)Calcular.IMC:
                    {
                        Console.WriteLine("Diguite seu peso(KG)");
                        float peso = float.Parse(Console.ReadLine());
                        Console.WriteLine("Diguite sua altura(M)");
                        float altura = float.Parse(Console.ReadLine());
                        if (validarOperadores.IMC(peso, altura))
                           Console.WriteLine(calculo.CalcularIMC(peso, altura));
                    };
                    break;
                    
                case (int)Calcular.Area: {
                        Console.Write(" Informe o raio do Círculo: ");
                        double raioDoCirculo = double.Parse(Console.ReadLine());

                        if (validarOperadores.Area(raioDoCirculo))
                        Console.WriteLine($"Área do circulo : {calculo.CalculaArea(raioDoCirculo).ToString("N2")}");
                    };
                    break;

                case (int)Calcular.RegraDeTres:
                    {
                        Console.Write("Insira o valor de A: ");
                        float a = float.Parse(Console.ReadLine());
                        Console.Write("Insira o valor de B: ");
                        float b = float.Parse(Console.ReadLine());
                        Console.Write("Insira o valor de C: ");
                        float c = float.Parse(Console.ReadLine());
                        Console.WriteLine($" Valor de X:{calculo.CalculaRegraDeTres(a,b,c)}");
                    };
                    break;

                case (3): Console.WriteLine(" Programa FINALIZADO COM SUCESSO");
                    Console.ReadKey();
                    System.Environment.Exit(0); break;

                default: MenuPrincipal(); break;
            }

            Console.ReadKey();
            MenuPrincipal();
            SelecionaOperacao();

        }
        
    }
}
