using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeroPrimo
{
    internal class MetodoPrimo
    {
        private int numero;
        public bool EsPrimo(int _numero)
        {
            numero = _numero;
            if (numero > 1)
            {
                for (int i = 2; i < Convert.ToInt32(Math.Pow(numero, 0.5)) + 1; i++)
                {
                    if (numero % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}
