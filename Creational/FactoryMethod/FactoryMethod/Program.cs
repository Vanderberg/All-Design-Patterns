using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var fm = new FactoryMethod();
            
            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();
            Console.WriteLine("Escolha seu personagem");
            var escolha = Console.ReadLine();

            IPersonagem personagem = fm.EscolherPersonagem(escolha);
            Console.WriteLine();
            
            
            Console.WriteLine("Você vai jogar com ");
            personagem.Escolhido();
            Console.ReadKey();
        }
    }
}