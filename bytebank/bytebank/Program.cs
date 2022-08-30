using bytebank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "10123-X";
conta1.numeroAgencia = 23;
conta1.nomeAgencia = "Agência Central";
conta1.saldo = 100;

Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Número Agencia: " + conta1.numeroAgencia);
Console.WriteLine("Nome Agencia: " + conta1.nomeAgencia);
Console.WriteLine("Saldo: " + conta1.saldo);

Console.ReadKey();