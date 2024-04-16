namespace SecFour
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public void NomePessoaMaisVelha(int verificacoes)
        {
            int maiorIdade = 0;
            string nomeMaisVelho = null;
            for (int i = 0; i < verificacoes; i++)
            {
                Console.WriteLine("---VERIFICAÇÃO DE PESSOA MAIS VELHA---");
                Console.WriteLine($"Informe o nome da pessoa nº {i + 1}");
                string Nome = Console.ReadLine();
                Console.WriteLine($"Informe a idade da pessoa nº {i + 1}");
                int idade = int.Parse(Console.ReadLine());     

                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                    nomeMaisVelho = Nome;
                }
            }
            
            Console.WriteLine($"A pessoa mais velha se chama {nomeMaisVelho} e sua idade é:{maiorIdade}");

        }


    }
}
