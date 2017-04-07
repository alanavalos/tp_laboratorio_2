using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Numero
    {
        private double numero;

        public double getNumero()//retorna el atributo privado a publico
        {
            return this.numero;
            }
        public Numero()
        {
            numero = 0;
            }
        public Numero(string auxNum)
        {
            setNumero(auxNum);
            }
        public Numero(double auxNumero)
        {
            numero = auxNumero;
            }
        private static double ValidarNumero(string numAux)
        {
            Numero num=new Numero();
            if (double.TryParse(numAux, out num.numero))
            {
                return num.numero;
            }
            else {
                return 0;
                 }
            }
        private void setNumero(string numeroAux)//para que no devuelva 0
        {
            numero=ValidarNumero(numeroAux);
            }
    }
}
