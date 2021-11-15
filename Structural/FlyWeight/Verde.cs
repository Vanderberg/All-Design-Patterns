using System;

namespace FlyWeight
{
    public class Verde : Tartaruga
    {
        public Verde()
        {
            this.condicao = "Tartaruga dentro do casco, ";
            this.acao = "Rodando no chão - ";
            
        }
        public override void Mostrar(string qualcor)
        {
            this.cor = qualcor;
            Console.WriteLine(this.condicao + this.acao + this.cor.ToUpper());
        }
    }
}