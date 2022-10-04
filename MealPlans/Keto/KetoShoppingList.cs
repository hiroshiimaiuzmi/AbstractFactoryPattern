using AbstractFactoryPattern.MealPlans;

namespace AbstractFactoryPattern.Factories.MealPlans.Keto;

public class KetoShoppingList : IShoppingList
{
    public List<string> MakeShoppingList()
        => new() { "butter", "meat", "kale", "peanut butter", "dark chocolate", "ricotta" };

}