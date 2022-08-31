using bytebank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

//Cliente cliente = new Cliente();
//cliente.Nome = "Leonardo";
//cliente.Cpf = "098-097-096-01";
//cliente.Profissao = "Programador";

ContaCorrente conta = new ContaCorrente();
Cliente Lola = new Cliente();
conta.Saldo = 150;
Console.WriteLine("Saldo = " + conta.Saldo);





Console.ReadKey();