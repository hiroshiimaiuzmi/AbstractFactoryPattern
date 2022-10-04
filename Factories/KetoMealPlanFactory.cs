using AbstractFactoryPattern.Factories.MealPlans.Keto;
using AbstractFactoryPattern.MealPlans;

namespace AbstractFactoryPattern.Factories;

public class KetoMealPlanFactory : IMealPlanFactory
{
    public IMenu GenerateDessertsMenu()
    {
        return new KetoDesertMenu();
    }

    public IMenu GenerateLunchesMenu()
    {
        return new KetoLunchMenu();
    }

    public IShoppingList GenerateShoppingList()
    {
        return new KetoShoppingList();
    }
}