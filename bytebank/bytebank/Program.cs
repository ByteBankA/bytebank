using bytebank;
using ByteBank;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");
        {
            try
            {
                ContaCorrente contaCorrente = new ContaCorrente(0001, 11112);
                ContaCorrente contaCorrente2 = new ContaCorrente(0002, 11113);

                contaCorrente.Depositar(50);
                Console.WriteLine(contaCorrente.Saldo);
                contaCorrente.Transferir(500, contaCorrente2);
                Console.WriteLine(contaCorrente.Saldo);


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no parâmetro " + ex.ParamName);
                Console.WriteLine("Ocorreu um erro do tipo Argument Exception");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);

            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("Informações da Inner Excpetion: ");
                Console.WriteLine(ex.InnerException.Message);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficenteException");
            }
        }
    }
}