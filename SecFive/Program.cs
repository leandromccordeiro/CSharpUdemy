using SecFive.Models;

Console.WriteLine("***ABERTURA DE CONTA***");
decimal deposito = 0;
Console.WriteLine("Informe o nome do novo correntista: ");
string nome = Console.ReadLine();
Console.WriteLine($"Informe um número para a conta de {nome}");
int numeroConta = int.Parse(Console.ReadLine());
Console.WriteLine("Deseja realizar um depósito inicial? (y/n)");
string resp = Console.ReadLine().ToLower().Trim();
if (resp == "y")
{
    Console.WriteLine("Informe o valor do depósito: ");
    deposito = decimal.Parse(Console.ReadLine());
}

Conta conta = new Conta(nome, numeroConta, deposito);

conta.Sacar(numeroConta, 500.00m);


//conta.Deposito(numeroConta, 700.00m);
conta.RetornaSaldo();