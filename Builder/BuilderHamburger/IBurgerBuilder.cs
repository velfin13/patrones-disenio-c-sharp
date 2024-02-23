

namespace BuilderHamburger
{
    public interface IBurgerBuilder
    {
        void AddBread();
        void AddMeat();
        void AddCheese();
        void AddDreassing();
        void AddLecttuce();
        void AddTomato();
        Burger GetBurger();
    }
}
