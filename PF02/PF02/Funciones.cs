using System;
using System.Collections.Generic;
using System.Text;

namespace PF02
{
    public class Funciones
    {

        /// <summary>
        /// Calcula el factorial de un número entero.
        /// </summary>
        /// <param name="n">Número del que se calcula el factorial.</param>
        /// <returns>El factorial de n, o -1 si n es negativo.</returns>
        public long CalcularFactorial(int n)
        {
            if (n < 0) return -1;

            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public bool EsContrasenyaValida(string contrasenya)
        {
            throw new System.NotImplementedException();
        }
    }
}