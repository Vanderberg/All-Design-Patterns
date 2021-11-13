using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criar um livro
            Livro livro = new Livro("João", "Desing Pattenrs", 10);
            livro.Exibe();
            
            //Criar um Video
            Video video = new Video("Rodrigo", "Video aula", 25, 3);
            video.Exibe();
            
            //Emprestar Video
            Console.WriteLine("\nEmprestando um vídeo");
            
            Emprestado emprestado = new Emprestado(video);
            emprestado.EmprestarItem("Carlos");
            emprestado.EmprestarItem("Maria");
            emprestado.Exibe();

            Console.WriteLine("\nDevolvendo um vídeo");
            emprestado.DevolverItem("Carlos");
            emprestado.Exibe();
            
            Console.ReadKey();
        }
        
    }
}