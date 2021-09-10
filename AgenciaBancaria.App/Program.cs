using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Capibaribe","54705300", "São lourenço da mata", "Pernambuco");
                Cliente cliente = new Cliente("Jonas","14059900400","548454542",endereco);

                ContaCorrente conta = new ContaCorrente(cliente,100);

                Console.WriteLine("Situacao da conta: {0}", conta.Situacao);
                Console.WriteLine("Numero da conta: {0} - {1}", conta.NumeroConta, conta.DigitoVerificador);
                Console.WriteLine();

                conta.AbrirConta("Senhasegura123");

                Console.WriteLine("Situacao da conta: {0}", conta.Situacao);
                Console.WriteLine("Numero da conta: {0} - {1}", conta.NumeroConta, conta.DigitoVerificador);
                Console.WriteLine();

                conta.Sacar(10, "Senhasegura123");
                Console.WriteLine("Saldo da conta: {0}", conta.Saldo);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
