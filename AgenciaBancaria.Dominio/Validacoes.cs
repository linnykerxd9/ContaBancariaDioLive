using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public static class Validacoes
    {
        public static string verifyNullOrWhiteSpace(this string value)
        {
            return string.IsNullOrWhiteSpace(value) ?
                     throw new Exception("Propriedade deve ser preenchida") :
                     value;
        }
    }
}
