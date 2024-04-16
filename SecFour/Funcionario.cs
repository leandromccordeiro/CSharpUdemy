using System.Security.AccessControl;

namespace SecFour
{
    public class Funcionario : Pessoa
    {
        public double Salario { get; set; }

        public double SalarioMedio (int verificacoes)
        {
            double salarioMedio = 0;
            
            for (int i = 0; i < verificacoes; i++)
            {
                Console.WriteLine($"Qual é o nome da {i + 1} pessoa?");
                Nome = Console.ReadLine();

                Console.WriteLine($"Qual é o salário da {Nome}?");
                Salario = double.Parse(Console.ReadLine());

                salarioMedio += Salario;
                
            }
            salarioMedio /= verificacoes;

            return salarioMedio;
        }

    }
}
