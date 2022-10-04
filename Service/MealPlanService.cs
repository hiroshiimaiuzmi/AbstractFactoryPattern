using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Email;

namespace AbstractFactoryPattern.Service;

public class MealPlanService : IMealPlanService
{
    private readonly IMealPlanFactory _factory;
    private readonly ISendsEmails _emailer;
    public MealPlanService(IMealPlanFactory factory, ISendsEmails emailer)
    {
        _factory = factory;
        _emailer = emailer;
    }

    public async Task SendMealPlanToSubscriber(string subscriberEmail)
    {
        Console.WriteLine($"--------------------------------------------------------------");
        var lunchMenu = _factory.GenerateLunchesMenu();
        var dessertMenu = _factory.GenerateDessertsMenu();
        var shoppingList = _factory.GenerateShoppingList();

        lunchMenu.PrintDescription();
        Console.WriteLine($"== 🍜 Compiling Lunches Menu for Subscriber: {subscriberEmail} ==", ConsoleColor.Cyan);
        lunchMenu.PrintMenu();

        dessertMenu.PrintDescription();
        Console.WriteLine($"== 🍰 Compiling Desserts Menu for Subscriber: {subscriberEmail} ==", ConsoleColor.Cyan);
        dessertMenu.PrintMenu();

        var ingredients = shoppingList.MakeShoppingList();

        var emailBody = string.Join(", ", ingredients);
        var message = new EmailMessage(subscriberEmail, emailBody);

        Console.WriteLine("== ✈️ Sending Subscriber Email ==", ConsoleColor.Cyan);

        await _emailer.SendMessage(message);

        Console.WriteLine($"--------------------------------------------------------------", ConsoleColor.Cyan);
    }
}