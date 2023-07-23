using System;
public class TaskForm
{
    private TaskManager taskManager;
    private readonly INotificationAdapter notificationAdapter;

    public TaskForm(TaskManager taskManager, INotificationAdapter notificationAdapter)
    {
        this.taskManager = taskManager;
        this.notificationAdapter = notificationAdapter;
    }

    public void Run()
    {
        Task newTask = new Task { Title = "Tâche de test", DueDate = DateTime.Now.AddDays(1) };
        taskManager.AddTask(newTask);
    }

}
