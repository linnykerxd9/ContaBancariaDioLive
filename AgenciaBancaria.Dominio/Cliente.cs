using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public Cliente(string nome, string cPF, string rG, Endereco endereco){
            Nome = nome.verifyNullOrWhiteSpace();
            CPF = cPF.verifyNullOrWhiteSpace();
            RG = rG.verifyNullOrWhiteSpace();
            Endereco = endereco ?? throw new Exception("Endereço deve ser informado");
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }

        public Endereco Endereco { get; set; }

    }
}
