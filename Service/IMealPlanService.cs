namespace AbstractFactoryPattern.Service;

public interface IMealPlanService
{
    Task SendMealPlanToSubscriber(string subscriberEmail);
}