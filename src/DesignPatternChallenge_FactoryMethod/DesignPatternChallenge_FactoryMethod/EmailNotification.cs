namespace DesignPatternChallenge_FactoryMethod;

public class EmailNotification(string recipient, string subject, string body, bool isHtml)
    : INotification
{
    public void Send()
    {
        Console.WriteLine($"📧 Enviando Email para {recipient}");
        Console.WriteLine($"   Assunto: {subject}");
        Console.WriteLine($"   Mensagem: {body}");
    }
}