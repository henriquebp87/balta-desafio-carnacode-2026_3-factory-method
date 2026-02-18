namespace DesignPatternChallenge_FactoryMethod;

internal class PushNotificationCreator(string deviceToken, string title, string message, int badge)
    : NotificationCreator
{
    public override INotification CreateNotification()
    {
        return new PushNotification(deviceToken, title, message, badge);
    }
}