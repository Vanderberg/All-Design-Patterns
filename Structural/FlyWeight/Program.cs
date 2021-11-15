using System;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---# Flyweight");
            
            FabricaFlyweight fabrica = new FabricaFlyweight();
            
            string cor = string.Empty;

            Tartaruga tartaruga;

            while (true)
            {
                Console.WriteLine();
                Console.Write("Qual tartaruga enviar para tela: ");
                cor = Console.ReadLine();

                tartaruga = fabrica.GetTartaruga(cor);
                
                tartaruga.Mostrar(cor);
                Console.WriteLine();
                Console.WriteLine("------------------------------------------");
            }
        }
    }
}