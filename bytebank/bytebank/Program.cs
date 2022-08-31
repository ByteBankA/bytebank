using bytebank;

Console.WriteLine("Boas Vindas ao seu banco, ByteBank!");

//Cliente cliente = new Cliente();
//cliente.Nome = "Leonardo";
//cliente.Cpf = "098-097-096-01";
//cliente.Profissao = "Programador";

ContaCorrente conta3 = new ContaCorrente();
conta3.Titular = new Cliente();
conta3.Titular.Nome = "Leonardo";
conta3.Titular.Cpf = "098-097-096-01";
conta3.Titular.Profissao = "Programador";
conta3.Conta = "9998887-x";
conta3.NumeroDaAgencia = 35;
conta3.NomeDaAgencia = "Agência Central";

if (conta3.Titular == null)
{
    Console.WriteLine("O campo tá nulo, não tá vendo?");
}
else
{
    Console.WriteLine(conta3.Titular.Nome);
}




Console.ReadKey();