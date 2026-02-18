namespace DesignPatternChallenge_FactoryMethod;

public class PushNotification(string deviceToken, string title, string message, int badge)
    : INotification
{
    public void Send()
    {
        Console.WriteLine($"🔔 Enviando Push para dispositivo {deviceToken}");
        Console.WriteLine($"   Título: {title}");
        Console.WriteLine($"   Mensagem: {message}");
    }
}