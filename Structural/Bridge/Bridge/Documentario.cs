namespace Bridge
{
    public class Documentario : ICanal
    {
        public string Canal()
        {
            return ("Sintonizado no Canal de Documentários");
        }

        public string Status()
        {
            return ("Você está assistindo - A Origem de tudo");
        }
    }
}