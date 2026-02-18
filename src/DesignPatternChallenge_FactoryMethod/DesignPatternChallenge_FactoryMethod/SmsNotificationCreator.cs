namespace DesignPatternChallenge_FactoryMethod;

internal class SmsNotificationCreator(string phoneNumber, string message)
    : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new SmsNotification(phoneNumber, message);
    }
}