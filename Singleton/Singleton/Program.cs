using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton jogador1 = Singleton.GetInstancia;
            jogador1.Mensagem("Jogador 1: A bola está comigo!");
            
            Singleton jogador2 = Singleton.GetInstancia;
            jogador2.Mensagem("Jogador 2: Recebeu a bola");
            
            Singleton jogador3 = Singleton.GetInstancia;
            jogador3.Mensagem("Jogador 3: Recebeu o lancemento");

            Console.ReadKey();
        }
    }
}