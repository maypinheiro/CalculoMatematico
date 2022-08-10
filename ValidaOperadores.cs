using System;


namespace CalculadoraDeValores
{
    class ValidaOperadores
    {
        public bool IMC(float peso, float altura)
        {
            if (peso < 2 || peso > 300 || altura < 0.30 || altura > 3.00) {
                Console.WriteLine("Valores Invalidos");
                return false;
            }

            return true;
        }

        public bool Area(double raioDoCirculo)
        {
            if (raioDoCirculo < 1) {
                Console.WriteLine("Valor Invalido");
                return false;
            } 
            else 
                return true;
        }
        public bool RegraDeTres(float a, float b, float c)
        {
            return true;

        }

    }
}
