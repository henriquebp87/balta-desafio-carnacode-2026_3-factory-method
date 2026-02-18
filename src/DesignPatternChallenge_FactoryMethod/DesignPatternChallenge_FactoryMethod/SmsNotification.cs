namespace DesignPatternChallenge_FactoryMethod;

public class SmsNotification(string phoneNumber, string message) : INotification
{
    public void Send()
    {
        Console.WriteLine($"📱 Enviando SMS para {phoneNumber}");
        Console.WriteLine($"   Mensagem: {message}");
    }
}