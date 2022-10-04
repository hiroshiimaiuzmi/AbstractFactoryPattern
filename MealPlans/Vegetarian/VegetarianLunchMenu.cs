using AbstractFactoryPattern.MealPlans;

namespace AbstractFactoryPattern.Factories.MealPlans.Keto;

public class VegetarianLunchMenu : IMenu
{
    public void PrintDescription()
        => Console.WriteLine("The Vegetarian menu features plant-based options without meat products");

    public void PrintMenu()
        => Console.WriteLine("Black Bean Soup, Green Curry, Salad");
}