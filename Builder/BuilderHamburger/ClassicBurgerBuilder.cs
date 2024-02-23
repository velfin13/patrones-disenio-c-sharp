

namespace BuilderHamburger
{
    public class ClassicBurgerBuilder : IBurgerBuilder
    {
        private Burger _burger = new Burger();
        public void AddBread()
        {
            _burger.Bread = "Su pan";
        }

        public void AddCheese()
        {
            _burger.Cheese = "Queso Cheddar";
        }

        public void AddDreassing()
        {
            _burger.Dressing = "Chimichurry";
        }

        public void AddLecttuce()
        {
            _burger.Lettuce = false;
        }

        public void AddMeat()
        {
            _burger.Meat = "Pollo";
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
