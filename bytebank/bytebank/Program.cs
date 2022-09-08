using ByteBank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");
{
    ContaCorrente conta = new ContaCorrente(7480, 874250);

    Console.WriteLine(ContaCorrente.TaxaOperacao);

    Console.ReadLine();
}
