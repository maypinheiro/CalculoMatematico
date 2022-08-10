using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDeValores
{
    class Calculos
    {
 
    
        public  float CalcularIMC(float peso, float altura)
        {
                float imc = peso / (altura * altura);
                return imc;
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
