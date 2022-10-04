using AbstractFactoryPattern.MealPlans;

namespace AbstractFactoryPattern.Factories.MealPlans.Keto;

public class VegetarianShoppingList : IShoppingList
{
    public List<string> MakeShoppingList()
        => new() { "black beans, spices, kale, cucumber", "mangoes", "apples", "pears" };
}