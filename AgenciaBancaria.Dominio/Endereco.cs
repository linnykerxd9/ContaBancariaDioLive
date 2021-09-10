using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Endereco
    {
        public Endereco(string logradouro, string cEP, string cidade, string estado)
        {
            Logradouro = logradouro.verifyNullOrWhiteSpace();
            CEP = cEP.verifyNullOrWhiteSpace();
            Cidade = cidade.verifyNullOrWhiteSpace();
            Estado = estado.verifyNullOrWhiteSpace();
        }

        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

    }
}
