using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testeTecnicoStart.Model
{
    public class ContaBancaria
    {
        private int NumeroConta;
        private string Titular;
        private decimal Saldo;

        public ContaBancaria(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
            Saldo = 0;
            Console.WriteLine($"Conta criada para {titular}.");
        }


        public void Depositar(decimal valor)
        {
            Saldo += valor;
            Console.WriteLine($"Depositando R$ {valor}.");
        }

        public void Sacar(decimal valor)
        {
            if (Saldo >= valor && valor > 0)
            {
                Saldo -= valor;
                Console.WriteLine($"Sacando R$ {valor}.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo atual: R${Saldo}.");
        }
    }
}