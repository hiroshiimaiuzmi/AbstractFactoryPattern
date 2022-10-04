using AbstractFactoryPattern.Factories.MealPlans.Keto;
using AbstractFactoryPattern.MealPlans;

namespace AbstractFactoryPattern.Factories;

public class VegetarianMealPlanFactory : IMealPlanFactory
{
    public IMenu GenerateDessertsMenu()
    {
        return new VegetarianDesertMenu();
    }

    public IMenu GenerateLunchesMenu()
    {
        return new VegetarianLunchMenu();
    }

    public IShoppingList GenerateShoppingList()
    {
        return new VegetarianShoppingList();
    }
}