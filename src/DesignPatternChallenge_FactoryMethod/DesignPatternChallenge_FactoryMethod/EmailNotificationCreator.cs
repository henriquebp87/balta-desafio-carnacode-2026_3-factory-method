namespace DesignPatternChallenge_FactoryMethod;

internal class EmailNotificationCreator(string recipient, string subject, string body, bool isHtml)
    : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new EmailNotification(recipient, subject, body, isHtml);
    }
}