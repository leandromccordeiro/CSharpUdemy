namespace SecFive.Models
{
    public class Conta
    {

        public string Nome { get; set; }
        public int NumeroConta { get; private set; }
        public decimal Saldo { get; private set; } = 0;

        public Conta(string nome, int numeroConta, decimal deposito = 0)
        {
            Nome = nome;
            NumeroConta = numeroConta;
            Saldo = deposito;
            Console.WriteLine($"\n**Conta Bancária criada com sucesso!!** \n" +
                $"Dados cadastrados:\n" +
                $"Nome: {nome}\n" +
                $"Número da Conta: {NumeroConta}\n" +
                $"Saldo no momento da abertura da conta: {Saldo.ToString("C")}");
        }

        public void Sacar(int numeroConta, decimal saque)
        {
            //if (saque > Saldo)
            //{
            //    throw new Exception("\n!!!!!!!Impossível realizar um saque maior que o saldo da conta!!!!!!!");
            //} else
            //{
            decimal tarifa = 5.00m;
            Saldo -= saque + tarifa;
            Console.WriteLine($"\nSaque no valor de R${saque} realizado com sucesso!");
            //}
        }

        public void Deposito(int numeroConta, decimal deposito)
        {
            Saldo += deposito;
            Console.WriteLine($"Depósito no valor de R${deposito} realizado com sucesso!");
        }

        public void RetornaSaldo()
        {
            Console.WriteLine($"\nO saldo da conta bancária é: R${Saldo}");
        }

    }
}
