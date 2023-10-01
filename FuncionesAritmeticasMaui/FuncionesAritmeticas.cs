using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesAritmeticasMaui
{
    public class FuncionesAritmeticas
    {
        public static double Sumar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }

        public static double Restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        public static double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        public static double Dividir(double numero1, double numero2)
        {
            if (numero2 != 0)
            {
                return numero1 / numero2;
            }
            else
            {
                throw new DivideByZeroException("División por cero no permitida");
            }
        }
    }
}
