using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = 0;
            string cpfAumento;
            int posicao = 0;
            double porcentagem = 0;

            Console.Write("Digite a quantidade de funcionarios que deseja cadastrar: ");
            quantidade = Convert.ToInt32(Console.ReadLine()!);

            List<Funcionarios> listaFuncionarios = new List<Funcionarios>();

            for( int i = 0; i < quantidade; i++ )
            {
                Console.WriteLine($"Digite o nome do funcionario {i + 1}:");
                string nome = Console.ReadLine()!;

                Console.WriteLine($"Digite o CPF do funcionario {i + 1}:");
                string cpf = Console.ReadLine()!;

                Console.WriteLine($"Digite o salario do funcionario {i + 1}:");
                double salario = Convert.ToInt32(Console.ReadLine()!);

                Funcionarios x = new Funcionarios(nome, cpf, salario);
                listaFuncionarios.Add(x);
            }

            do
            {
                Console.Write("Digite o CPF do funcionario que recebera aumento: ");
                cpfAumento = Console.ReadLine()!;

                posicao = listaFuncionarios.FindIndex(x => x.cpf == cpfAumento);

                if (posicao == -1)
                {
                    Console.WriteLine("Funcionario nao encontrado. Tente novamente.");
                }
                else
                {
                    Console.Write("Digite a porcentagem de aumento: ");
                    porcentagem = Convert.ToDouble(Console.ReadLine()!);

                    listaFuncionarios[posicao].aumentoSalario(porcentagem);
                }
            }
            while (posicao == -1);

            Console.WriteLine("Lista atualizada dos funcionarios: ");

            foreach( Funcionarios element in listaFuncionarios)
            {
                Console.WriteLine($"Nome: {element.nome}");
                Console.WriteLine($"CPF: {element.cpf}");
                Console.WriteLine($"Salario: {element.salario}");
                Console.WriteLine("----------------------------");
            }
        }
    }
}