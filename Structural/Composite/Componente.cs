﻿using System;
using System.Globalization;

namespace Composite
{
    public abstract class Componente
    {
        protected string nome;

        public Componente(String nome)
        {
            this.nome = nome;
        }

        public abstract void Adicionar(Componente c);
        public abstract void Remover(Componente c);
        public abstract void Mostrar(int profundidade);
    }
}