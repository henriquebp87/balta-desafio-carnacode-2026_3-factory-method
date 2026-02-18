namespace DesignPatternChallenge_FactoryMethod
{
    internal class NotificationManager
    {
        public void SendNotification(NotificationCreator creator)
        {
            var notification = creator.CreateNotification();
            notification.Send();
        }
    }
}
