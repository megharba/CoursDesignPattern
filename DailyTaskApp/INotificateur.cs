public interface INotificateur
{
    void SetNext(INotificateur notificateur);
    void HandleNotification(Task task);
}