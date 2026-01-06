using System;

namespace curso
{
    class Funcionarios
    {
       public string nome { get; set; }
       public string cpf { get; set;}

       public double salario { get; set;}

       public Funcionarios(string nome, string cpf, double salario)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.salario = salario;
        }

        public void aumentoSalario(double porcentagem)
        {
            salario += porcentagem * salario / 100;
        }
    }
}