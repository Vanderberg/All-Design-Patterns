using System;

namespace Adapter
{
    // é o nosso Adaptee - Ele é o objeto que será adaptado
    public class RoboInimigo
    {
        
        private Random gerador = new Random();

        public void EsmagarComMaos()
        {
            int DanoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine("O Robo inimigo causou " + DanoAtaque + " de dano com o ataque de Esmagar com as Mãos" );
        }

        public void AndarFrente()
        {
            int moviemento = gerador.Next(10) + 1;
            Console.WriteLine("O Robo Inimigo andou " + moviemento + " passos para frente");
        }

        public void ReagirContraHumano(String piloto)
        {
            Console.WriteLine("O Robo inimigo vai contra o " + piloto);
        }
        
    }
}