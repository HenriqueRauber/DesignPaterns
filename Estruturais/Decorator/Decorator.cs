using System; 

namespace Decorator
{
    //Decorador abstrato
    public class Decorator : ItemBiblioteca
    {
        protected ItemBiblioteca itemBiblioteca;
        public Decorator(ItemBiblioteca itemBiblioteca)
        {
            this.itemBiblioteca = itemBiblioteca;
        }
        public override void Exibe()
        {
            this.itemBiblioteca.Exibe();
        }
    }
}
