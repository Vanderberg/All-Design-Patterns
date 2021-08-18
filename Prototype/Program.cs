using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioPermanente funcionarioPermanente = new FuncionarioPermanente();
            funcionarioPermanente.Nome = "João";
            funcionarioPermanente.Idade = 30;
            funcionarioPermanente.Tipo = "Permanente";

            FuncionarioPermanente Clone_funcionarioPermanente = (FuncionarioPermanente) funcionarioPermanente.Clone();
            Clone_funcionarioPermanente.Nome = "Carlos";
            Clone_funcionarioPermanente.Idade = 40;

            Console.WriteLine("Detalhes do Funcionário permanente");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}; ", funcionarioPermanente.Nome, funcionarioPermanente.Idade, funcionarioPermanente.Tipo);
            Console.WriteLine("");    
            Console.WriteLine("Detalhes do Funcionário permanente CLONE");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}; ", Clone_funcionarioPermanente.Nome, Clone_funcionarioPermanente.Idade, Clone_funcionarioPermanente.Tipo);
        }
    }
}