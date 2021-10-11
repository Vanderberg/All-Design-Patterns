namespace Bridge
{
    public class Culinaria : ICanal
    {
        public string Canal()
        {
            return ("Sintonizado no Canal de Culinária");
        }

        public string Status()
        {
            return ("Você está assistindo - Receita de bolo de Laranja");
        }
    }
}