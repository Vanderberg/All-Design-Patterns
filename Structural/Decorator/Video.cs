using System;

namespace Decorator
{
    public class Video : ItemBiblioteca
    {
        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int MinutosDuracao { get; set; }

        public Video(string diretor, string titulo, int minutosDuracao, int numerocopias)
        {
            this.Diretor = diretor;
            this.Titulo = titulo;
            this.NumeroCopias = numerocopias;
            this.MinutosDuracao = minutosDuracao;
        }
        public override void Exibe()
        {
            Console.WriteLine("\nVideo -----");
            Console.WriteLine(" Diretor: " + this.Diretor);
            Console.WriteLine(" Título: " + this.Titulo);
            Console.WriteLine(" Duração: " + this.MinutosDuracao);
            Console.WriteLine(" # Cópias: " + this.NumeroCopias);
        }
    }
}