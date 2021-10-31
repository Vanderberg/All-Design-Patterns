using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo rx2018 = new TanqueInimigo();
            RoboInimigo R2D2 = new RoboInimigo();
            
            IAtaqueInimigo robo_adapter = new RoboInimigoAdapter(R2D2);

            Console.WriteLine("====== ROBO =======");
            R2D2.ReagirContraHumano("Rodrigo");
            R2D2.AndarFrente();
            R2D2.EsmagarComMaos();
            
            Console.WriteLine("====== TANQUE =======");
            rx2018.Pilotar("João");
            rx2018.Movimenta();
            rx2018.ArmaFogo();

            Console.WriteLine("====== ROBO ADAPTADO =======");
            robo_adapter.Pilotar("Maria");
            robo_adapter.Movimenta();
            robo_adapter.ArmaFogo();
        }
    }
}