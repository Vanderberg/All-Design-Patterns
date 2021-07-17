using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
           //Cria Fabricante
           Fabricante fabricante = new Fabricante();
           
           //Permite que a classe Builder esteja pronta
           ICelular celularBuilder = null;
           
           //Agora vamos criar um telefone Android
           celularBuilder = new AndroidBuilder();
           //celularBuilder = new IPhoneBuilder();
           fabricante.Constructor(celularBuilder);
           
           Console.WriteLine("Celular Fabricado: " + celularBuilder.Celular.Nome);
           Console.WriteLine("Camera: " + celularBuilder.Celular.Camera);
           Console.WriteLine("Bateria: " + celularBuilder.Celular.Bateria);
           Console.WriteLine("Sistema Operacional: " + celularBuilder.Celular.SistemaOperacional);
           Console.WriteLine("Tela: " + celularBuilder.Celular.Tela);
           
           Console.ReadKey();
        }
    }
}