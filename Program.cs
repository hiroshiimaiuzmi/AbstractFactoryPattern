using AbstractFactoryPattern.Email;
using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Service;

Console.WriteLine("Please enter customer email address.");
var customerEmail = Console.ReadLine();

if(string.IsNullOrWhiteSpace(customerEmail))
{
    Console.WriteLine("Error reading customer email address");
    throw new InvalidOperationException();
}

try
{
    var dietType = GetCustomer(customerEmail);
    var mealPlanFactory = GetFactoryForDietType(dietType);
    IMealPlanService mealPlanService = new MealPlanService(mealPlanFactory, new Emailer());
    mealPlanService.SendMealPlanToSubscriber(customerEmail);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    throw;
}

IMealPlanFactory GetFactoryForDietType(string dietType)
=> dietType switch {
    "keto" => new KetoMealPlanFactory(),
    "vegetarian" => new VegetarianMealPlanFactory(),
    _ => throw new InvalidOperationException(),
};

string GetCustomer(string customerEmail)
{
    return customerEmail == "hiroshi@example.com" ? "keto" : "vegetarian";
}