using bytebank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "André Silva";
conta1.conta = "10123-X";
conta1.numeroAgencia = 23;
conta1.nomeAgencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta2.titular = "Ananda Silva";
conta2.conta = "111999-X";
conta2.numeroAgencia = 28;
conta2.nomeAgencia = "Agência Central";
conta2.saldo = 100;

Console.WriteLine("Saldo da Amanda pré transferência: " + conta2.saldo);
Console.WriteLine("Saldo do André pré transferência: " + conta1.saldo);
bool transferencia = conta1.Transferir(50, conta2);
Console.WriteLine("Transferência realizada com sucesso!");
Console.WriteLine("Saldo da Amanda pós transferência: " + conta2.saldo);
Console.WriteLine("Saldo do André pós transferência: " + conta1.saldo);

Console.ReadKey();