
using System;
using System.Collections.Generic;
public class TaskManager
    {
        private static TaskManager instance;
        private List<Task> tasks;
        private INotificateur taskHandler; // Référence au maillon de la chaîne de responsabilité

        private TaskManager()
        {
            tasks = new List<Task>();
            taskHandler = new CompletedTaskHandler();
            taskHandler.SetNext(new OverdueTaskHandler());
            // Ajoutez d'autres gestionnaires selon vos besoins
        }

        public static TaskManager GetInstance()
        {
            if (instance == null)
            {
                instance = new TaskManager();
            }
            return instance;
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
            taskHandler.HandleNotification(task); // Déclenche le traitement de la nouvelle tâche ajoutée
        }

        public void RemoveTask(Task task)
        {
            tasks.Remove(task);
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }

        // Autres méthodes pour gérer les tâches (update, markup, etc.)
    }