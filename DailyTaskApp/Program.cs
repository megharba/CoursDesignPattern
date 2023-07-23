using System;
class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = TaskManager.GetInstance();
            var notificationAdapter = new NotificationAdapter();

            TaskForm taskForm = new TaskForm(taskManager, notificationAdapter);
            taskForm.Run();

            Console.ReadLine();
        }
    }