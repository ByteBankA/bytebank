namespace bytebank
{
    public class ContaCorrente
    {
        public string? Conta { get; set; }
        public int? NumeroDaAgencia { get; set; }
        public string? NomeDaAgencia { get; set; }
        public double? Saldo { get; set; }
        public bool? Sacar(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (Saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                Saldo = Saldo - valor;
                destino.Saldo = destino.Saldo + valor;
                return true;
            }
        }
    }
}