namespace Adapter
{
    // é o Adapter - O Adaptador do Objeto Robo com Tanque
    public class RoboInimigoAdapter: IAtaqueInimigo
    {
        private RoboInimigo robo;

        //Passa para o método construtor o Robo que será adptado (Nosso adaptee)
        public RoboInimigoAdapter(RoboInimigo novoRobo)
        {
            this.robo = novoRobo;
        }
        
        public void ArmaFogo()
        {
            this.robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            this.robo.AndarFrente();
        }

        public void Pilotar(string piloto)
        {
            this.robo.ReagirContraHumano(piloto);
        }
    }
}