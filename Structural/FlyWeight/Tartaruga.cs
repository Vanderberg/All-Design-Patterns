using System;

namespace FlyWeight
{
    public abstract class Tartaruga
    {
        protected string condicao;
        protected string acao;
        public string cor { get; set; }

        public abstract void Mostrar(string cor);
    }
}