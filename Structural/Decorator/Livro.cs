﻿using System;

namespace Decorator
{
    public class Livro : ItemBiblioteca
    {
        public string Autor { get; set; }

        public string Titulo { get; set; }

        public Livro(String autor, String titulo, int numeroCopias)
        {
            this.Autor = autor;
            this.Titulo = titulo;
            this.NumeroCopias = numeroCopias;
        }
        
        public override void Exibe()
        {
            Console.WriteLine("\nLivro -----");
            Console.WriteLine(" Autor: " + this.Autor);
            Console.WriteLine(" Título: " + this.Titulo);
            Console.WriteLine(" # Cópias: " + this.NumeroCopias);
        }
    }
}