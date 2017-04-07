using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Calculadora
    {

        public static double operar(Numero num1, Numero num2, string operador)
        {
            double retorno;//guardar en retorno
            switch (validarOperador(operador))
            {
                case "+":
                    retorno=num1.getNumero() + num2.getNumero();
                 break;
                case"-":
                 retorno = num1.getNumero() - num2.getNumero();
                 break;
                case"/":
                 if (num2.getNumero() == 0)
                 {
                     retorno = 0;
                 }
                 else {
                     retorno = num1.getNumero() / num2.getNumero();
                 }
                 break;
                case"*":
                 retorno = num1.getNumero() * num2.getNumero();
                    break;

                default: retorno =0;
                    break;
             }
 
            return retorno;
            }
        
        public static string validarOperador(string operadorAux)
        {
            if (operadorAux != "+" && operadorAux != "-" && operadorAux != "*" && operadorAux != "/")
            {
                return "+";
            }
            else {
               return operadorAux;
            }

            }
    }
}
