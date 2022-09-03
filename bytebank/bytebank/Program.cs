using bytebank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

//Cliente cliente = new Cliente();
//cliente.Nome = "Leonardo";
//cliente.Cpf = "098-097-096-01";
//cliente.Profissao = "Programador";

//Cliente cliente = new Cliente();
//cliente.Nome = "Lola";

//ContaCorrente conta = new ContaCorrente("125258-x", 235);
//conta.Saldo = 100;
//conta.Titular = cliente;
//Console.WriteLine(conta.Titular.Nome);
//Console.WriteLine(conta.Saldo);
//Console.WriteLine(conta.NumeroDaAgencia);
//Console.WriteLine(conta.Conta);


ContaCorrente contaX = new ContaCorrente("125258-x", 235);
//contaX.TotalDeContasCriadas = 1;
ContaCorrente contaY = new ContaCorrente("853521-x", 532);
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);



Console.ReadKey();