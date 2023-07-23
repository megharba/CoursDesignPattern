using System;
public abstract class TaskHandler : INotificateur
{
    protected INotificateur nextNotificateur; // Le maillon suivant de la chaîne de responsabilité

    public void SetNext(INotificateur notificateur)
    {
        nextNotificateur = notificateur;
    }

    public abstract void HandleNotification(Task task);
}

public class CompletedTaskHandler : TaskHandler
{
    public override void HandleNotification(Task task)
    {
        if (task.IsCompleted)
        {
            Console.WriteLine($"La tâche '{task.Title}' a été marquée comme terminée !");
        }
        else if (nextNotificateur != null)
        {
            nextNotificateur.HandleNotification(task); // Passe la tâche au maillon suivant s'il existe
        }
    }
}

public class OverdueTaskHandler : TaskHandler
{
    public override void HandleNotification(Task task)
    {
        if (task.DueDate < DateTime.Now && !task.IsCompleted)
        {
            Console.WriteLine($"Attention ! La tâche '{task.Title}' est en retard !");
        }
        else if (nextNotificateur != null)
        {
            nextNotificateur.HandleNotification(task); // Passe la tâche au maillon suivant s'il existe
        }
    }
}