using System;

namespace CalculadoraDeValores
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal();
        }
        static void MenuPrincipal()
        {
            Calculos calculo = new Calculos();
            ValidaOperadores validaOperadores = new ValidaOperadores();

            Console.Clear();
            Console.WriteLine("Escolha um Opção");
            Console.WriteLine("1- Calculadora IMC");
            Console.WriteLine("2- Calculadora Area Circulo");
            Console.WriteLine("3- Calculadora regra de 3");
            Console.WriteLine("4- Sair");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Selecione uma Opção");


            int op = int.Parse(Console.ReadLine()) -1;

            switch (op)
            {

                case (int)Calcular.IMC: {
                        Console.Write("Diguite seu peso (Kg):  ");
                        float peso = float.Parse(Console.ReadLine());
                        Console.Write("Diguite sua altura (M):  ");
                        float altura = float.Parse(Console.ReadLine());
                        float imc;
                        string texto;

                        if (validaOperadores.IMC(peso, altura)) {
                            imc = calculo.CalcularIMC(peso, altura);
                                if (imc < 18.5)      texto= "A baixo do peso.";
                                else if (imc < 24.9) texto= "Peso Normal.";
                                else if (imc < 29.9) texto = "Excesso de peso.";
                                else if (imc < 35)   texto = "Obesidade.";
                                else texto = "Obesidade extrema.";
                            Console.WriteLine(texto + " IMC: " + imc.ToString());
                            Console.ReadKey();
                            MenuPrincipal();
                        }
                        else
                        {
                            Console.ReadKey();
                            MenuPrincipal();
                        }
                    };
                    break;

                case (int)Calcular.Area: {
                        Console.Write(" Informe o raio do Círculo: ");

                        double raioDoCirculo = double.Parse(Console.ReadLine());
                        if (validaOperadores.Area(raioDoCirculo))
                            Console.WriteLine(calculo.CalculaArea(raioDoCirculo));

                        Console.ReadKey();
                        MenuPrincipal();
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
                        Console.WriteLine(calculo.CalculaRegraDeTres(a,b,c));
                        Console.ReadKey();
                        MenuPrincipal();

                    };
                    break;

                case (3): Console.WriteLine("Programa FINALIZADO COM SUCESSO");
                    Console.ReadKey();
                    System.Environment.Exit(0); break;
                default: MenuPrincipal(); break;
            }
        }


    }
}
