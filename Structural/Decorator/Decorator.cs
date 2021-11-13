namespace Decorator
{
    //Decorator abstrato
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca ItemBiblioteca { get; set; }

        public Decorator(ItemBiblioteca itemBiblioteca)
        {
            this.ItemBiblioteca = itemBiblioteca;
        }
        
        public override void Exibe()
        {
            this.ItemBiblioteca.Exibe();
        }
    }
}