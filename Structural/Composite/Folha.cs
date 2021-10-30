using System;

namespace Composite
{
    public class Folha : Componente
    {
        public Folha(string nome) : base(nome)
        {
        }

        public override void Adicionar(Componente c)
        {
            Console.WriteLine("Não é possivel ADICIONAR a folha!");
        }

        public override void Remover(Componente c)
        {
            Console.WriteLine("Não é possivel REMOVER a folha!");
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new string('-', profundidade) + nome );
        }
    }
}