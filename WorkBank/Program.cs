using System;

namespace WorkBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();
            conta1.Titular = "Alessandro";
            conta1.NumeroAgencia = 777;
            conta1.Conta = "020777-X";
            conta1.Saldo = 560;            
            Console.WriteLine($"Saldo conta 1 = {conta1.Saldo}");

            ContaCorrente conta2 = new ContaCorrente();
            conta2.Titular = "Maria";
            conta2.NumeroAgencia = 17;
            conta2.Conta = "123336-8";
            conta2.Saldo = 240;
            Console.WriteLine($"Saldo conta 2 = {conta2.Saldo}");

            conta1.Transferir(60, conta2);
            Console.WriteLine($"Saldo conta 1 pós transferência = {conta1.Saldo}");
            Console.WriteLine($"Saldo conta 2 pós transferência = {conta2.Saldo}");
        }
    }
}
