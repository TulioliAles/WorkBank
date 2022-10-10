using System;

namespace WorkBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Titular = "Alessandro";
            conta.NumeroAgencia = 777;
            conta.Conta = "020777-X";
            conta.Saldo = 560;
            
            Console.WriteLine($"Saldo = {conta.Saldo}");
        }
    }
}
