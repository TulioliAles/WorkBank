namespace WorkBank
{
    public class ContaCorrente
    {
        public int NumeroAgencia { get; set; }
        public string Conta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if(valor <= this.Saldo)
            {
                this.Saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(valor <= this.Saldo)
            {
                this.Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
