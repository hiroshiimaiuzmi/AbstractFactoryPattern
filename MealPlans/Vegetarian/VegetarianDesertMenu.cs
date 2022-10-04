using AbstractFactoryPattern.MealPlans;

namespace AbstractFactoryPattern.Factories.MealPlans.Keto;

public class VegetarianDesertMenu : IMenu
{
    public void PrintDescription()
        => Console.WriteLine("The Vegetarian dessert menu features plant-based " +
                "baked goods and fresh fruit");

    public void PrintMenu()
        => Console.WriteLine("Brownie, Orange Sherbert, Blackberry Crisp");
}