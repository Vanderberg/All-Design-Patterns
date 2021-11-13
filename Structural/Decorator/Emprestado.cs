using System;
using System.Collections.Generic;

namespace Decorator
{
    public class Emprestado : Decorator
    {
        protected List<string> Emprestados = new List<string>();
        
        public Emprestado(ItemBiblioteca itemBiblioteca) : base(itemBiblioteca)
        {
        }

        public void EmprestarItem(string nome)
        {
            this.Emprestados.Add(nome);
            this.ItemBiblioteca.NumeroCopias--;
        }

        public void DevolverItem(String nome)
        {
            this.Emprestados.Remove(nome);
            this.ItemBiblioteca.NumeroCopias++;
        }

        public override void Exibe()
        {
            base.Exibe();
            foreach (var item in this.Emprestados)
            {
                Console.WriteLine("Emprestado: " + item);
            }
        }
    }
}