using AbstractFactoryPattern.MealPlans;

namespace AbstractFactoryPattern.Factories.MealPlans.Keto;

public class KetoDesertMenu : IMenu
{
    public void PrintDescription()
        => Console.WriteLine("The Keto dessert menu features high-fat, sugar-free " +
                "chocolate bars and high-fat low carbo cheesecake");
    

    public void PrintMenu()
        => Console.WriteLine("Peanut butter chocolate bars, sugar-free cheesecake");
}