namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente? Titular { get; set; }
        private string? _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }

        private int _numero_da_agencia;
        public int NumeroDaAgencia
        {
            get
            {
                return _numero_da_agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numero_da_agencia = value;
                }
            }
        }
        private string _nome_da_agencia;
        public string NomeDaAgencia
        {
            get
            {
                return _nome_da_agencia;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _nome_da_agencia = value;
                }
            }
        }
        private double saldo { get; set; }
        public bool Sacar(double valor)
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

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }

        public ContaCorrente(string conta, int numeroDaAgencia)
        {
            Conta = conta;
            NumeroDaAgencia = numeroDaAgencia;
            TotalDeContasCriadas += 1;
        }

        public static int TotalDeContasCriadas { get; set; }

        public ContaCorrente(Cliente? titular, string? conta, int numero_da_agencia, int numeroDaAgencia, string nome_da_agencia, string nomeDaAgencia, double saldo)
        {
            Titular = titular;
            Conta = conta;
            _numero_da_agencia = numero_da_agencia;
            NumeroDaAgencia = numeroDaAgencia;
            _nome_da_agencia = nome_da_agencia;
            NomeDaAgencia = nomeDaAgencia;
            Saldo = saldo;
        }
    }
}