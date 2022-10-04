namespace AbstractFactoryPattern.Email;

public record EmailMessage(string To, string Content);

public interface ISendsEmails
{
    public Task SendMessage(EmailMessage message);
}

public class Emailer : ISendsEmails
{
    public async Task SendMessage(EmailMessage message)
    {
        await Task.Delay(1000);
        Console.WriteLine($"SentMessage to : {message.To} with Message: {message.Content}");
    }
}