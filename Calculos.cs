using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeValores
{
    class Calculos
    {
 
        public  String CalcularIMC(float peso, float altura)
        {
                float imc = peso / (altura * altura);
                string resultado =" ";
 
            if (imc < 18.5) resultado =" A baixo do peso.";
                else if (imc < 24.9) resultado = "Peso Normal.";
                else if (imc < 29.9) resultado = " Excesso de peso.";
                else if (imc < 35) resultado =   " Obesidade.";
                else resultado = "Obesidade extrema.";

            return resultado;
           

        }
        public  double CalculaArea( double raioDoCirculo)
        {
                 double areaCirculo = Math.PI * Math.Pow(raioDoCirculo, 2);
                return areaCirculo; 
        }
        public  float CalculaRegraDeTres(float a, float b, float c)
        {
                float d = (c * b) / a;
                return d;
        }

    }

}
