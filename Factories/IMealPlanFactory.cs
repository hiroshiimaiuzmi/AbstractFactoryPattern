using AbstractFactoryPattern.MealPlans;

namespace AbstractFactoryPattern.Factories;

public interface IMealPlanFactory
{
    IMenu GenerateLunchesMenu();
    IMenu GenerateDessertsMenu();
    IShoppingList GenerateShoppingList();
}