using ByteBank.Conta;
using ByteBank.Titular;

Cliente clienteAndre = new Cliente();
clienteAndre.nome = "Andre solva";
clienteAndre.cpf = "123456789";
clienteAndre.profissao = "analisador";
ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = clienteAndre;
contaDoAndre.Numero_Agencia = 12;
contaDoAndre.conta = "1010-x";
contaDoAndre.DefinirSaldo(100);

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.ObterSaldo());

Console.WriteLine("Saldo da conta do André = " + contaDoAndre.titular.nome);


contaDoAndre.Depositar(100);

Console.WriteLine("Saldo da conta do André pôs-deposito = " + contaDoAndre.ObterSaldo());

contaDoAndre.Sacar(300);

if (contaDoAndre.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta do André pôs-deposito = " + contaDoAndre.ObterSaldo());
}
else
{
    Console.WriteLine("Saldo da conta inferior ao pedido.");
}

ContaCorrente contaDaMaria = new ContaCorrente(17, "1011-5");
contaDaMaria.titular = new Cliente();
contaDaMaria.titular.nome = "Maria Souza";
contaDaMaria.titular.cpf = "987654321";
contaDaMaria.titular.profissao = "analisador";
contaDaMaria.DefinirSaldo (100);

contaDoAndre.transferir(50, contaDaMaria);
Console.WriteLine("Saldo da conta do André pôs-deposito = " + contaDoAndre.ObterSaldo());
Console.WriteLine("Saldo da conta do André pôs-deposito = " + contaDaMaria.ObterSaldo());
Console.WriteLine(ContaCorrente.TotalCriadas);