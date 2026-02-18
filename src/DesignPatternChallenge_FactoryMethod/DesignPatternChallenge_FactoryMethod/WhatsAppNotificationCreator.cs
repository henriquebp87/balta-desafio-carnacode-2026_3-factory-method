namespace DesignPatternChallenge_FactoryMethod;

internal class WhatsAppNotificationCreator(string phoneNumber, string message, bool useTemplate)
    : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new WhatsAppNotification(phoneNumber, message, useTemplate);
    }
}