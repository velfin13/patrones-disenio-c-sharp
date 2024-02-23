

namespace BuilderHamburger
{
    public class BurgerDirectory
    {
        public void MakeBurger(IBurgerBuilder burgerBuilder)
        {
            burgerBuilder.AddBread();
            burgerBuilder.AddCheese();
            burgerBuilder.AddLecttuce();
            burgerBuilder.AddDreassing();
            burgerBuilder.AddMeat();
            burgerBuilder.AddTomato();
        }
    }
}
