using ByteBank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");
{
    try
    {
        ContaCorrente contaCorrente = new ContaCorrente(0, 0);
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine("Erro no parâmetro " + ex.ParamName);
        Console.WriteLine("Ocorreu um erro do tipo Argument Exception");
        Console.WriteLine(ex.Message);

    }



}
