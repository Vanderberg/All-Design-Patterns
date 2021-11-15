﻿using System;

namespace FlyWeight
{
    public class Vermelha : Tartaruga
    {
        public Vermelha()
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