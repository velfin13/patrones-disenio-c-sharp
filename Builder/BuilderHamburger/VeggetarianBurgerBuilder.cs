

namespace BuilderHamburger
{
    public class VeggetarianBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger = new Burger();
        public void AddBread()
        {
            _burger.Bread = "Integral";
        }

        public void AddCheese()
        {
            _burger.Cheese = "Sin sal y vegana";
        }

        public void AddDreassing()
        {
            _burger.Dressing = "Ckeckchuck";
        }

        public void AddLecttuce()
        {
            _burger.Lettuce = true;
        }

        public void AddMeat()
        {
            _burger.Meat = "Vegan meat";
        }

        public void AddTomato()
        {
            _burger.Tomato = true;
        }

        public Burger GetBurger()
        {
            return _burger;
        }
    }
}
