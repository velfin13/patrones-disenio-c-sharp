using BuilderHamburger;

BurgerDirectory chef =  new();

ClassicBurgerBuilder classicBurgerbuilder = new();
chef.MakeBurger(classicBurgerbuilder);
Burger classicBurger = classicBurgerbuilder.GetBurger();
Console.WriteLine("Clasicc Hamburger");
classicBurger.DisplayInformation();

Console.WriteLine("\n");

VeggetarianBurgerBuilder veggetarianBurgerbuilder = new();
chef.MakeBurger(veggetarianBurgerbuilder);
Burger veggetarianBurger = veggetarianBurgerbuilder.GetBurger();
Console.WriteLine("Veggetarian Hamburger");
veggetarianBurger.DisplayInformation();