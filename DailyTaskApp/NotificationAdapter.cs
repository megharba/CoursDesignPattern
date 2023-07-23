using System;
public class NotificationAdapter : INotificationAdapter
{
    // Logique pour envoyer les notifications via la source spécifique (console dans notre cas)
    public void SendNotification(string message)
    {
        Console.WriteLine(message);
    }
}