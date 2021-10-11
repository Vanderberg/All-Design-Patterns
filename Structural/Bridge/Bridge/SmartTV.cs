using System;

namespace Bridge
{
    public class SmartTV
    {
        //Aqui temos a ponte (Bridge), No program chama essa interface e passamos para ela o Objeto.
        public ICanal CanalAtual { get; set; }

        public void ExibeCanalSintonizado()
        {
            if (CanalAtual != null)
                Console.WriteLine(CanalAtual.Canal());
            else
                Console.WriteLine("Por favor, Selecione um canal");
        }

        public void PlayTv()
        {
            if (CanalAtual != null)
                Console.WriteLine(CanalAtual.Status());
            else
                Console.WriteLine("Por favor, Selecione um canal para assistir");   
        }
    }
}