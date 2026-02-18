namespace DesignPatternChallenge_FactoryMethod;

public class WhatsAppNotification(string phoneNumber, string message, bool useTemplate) : INotification
{
    public void Send()
    {
        Console.WriteLine($"💬 Enviando WhatsApp para {phoneNumber}");
        Console.WriteLine($"   Mensagem: {message}");
        Console.WriteLine($"   Template: {useTemplate}");
    }
}